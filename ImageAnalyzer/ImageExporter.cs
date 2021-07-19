using RockMakerModel;
using RockMaker.Business.PlateView.Imaging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Configuration;

namespace ImageAnalyzer
{
    class ImageExporter
    {
        private string _targetBasePath;
        private bool _exportAllInspections;
        private string _scoreGroupName;
        private string _filterCaptureProfiles;
        
        public ImageExporter(string pathToRM, string targetBasePath)
        {
            this._targetBasePath = targetBasePath;

            _exportAllInspections = ConfigurationManager.AppSettings.GetValues("InspectionsToExport")[0].ToLower().Equals("all");
            _scoreGroupName = ConfigurationManager.AppSettings.GetValues("ScoreGroupName")[0].ToLower();
            _filterCaptureProfiles = ConfigurationManager.AppSettings.GetValues("CaptureProfilesFilter")[0].ToLower();
    }

        public int ExportPlate(long plateID, int imageBatchIdx)
        {
            int num = 0;
            var q = GetImages(plateID);
            //Console.WriteLine(q.ToString());
            List<ImageResults> list = q.ToList<ImageResults>();
            if (list.Count == 0)
              return 0;

            int imageBatchId = ImageExporter.GetLatestImageBatchID(list, imageBatchIdx);
            var destFolder = GetFolder(_targetBasePath, list[0].PlateBarcode);

            using (StreamWriter streamWriter = new StreamWriter(Path.Combine(destFolder, "report.csv")))
            {
                streamWriter.WriteLine("{0:MM/dd/yy HH:mm:ss}", (object)ImageExporter.GetDispenseDate(plateID));
                foreach (ImageResults imageResults in list)
                {
                    if (imageResults.ImageBatchID == imageBatchId || _exportAllInspections)
                    {
                        var folder = GetFolder(destFolder, imageResults.ScoreName);

                        string srcFileName = string.Format("{0}\\WellImages\\{1}\\plateID_{2}\\batchID_{3}\\wellNum_{4}\\profileID_{5}\\d{6}_r{7}_{8}", 
                                                           imageResults.BasePath, (imageResults.PlateID % 1000L), imageResults.PlateID, imageResults.ImageBatchID, 
                                                           imageResults.WellNumber, imageResults.CaptureProfileID, imageResults.DropNumber, imageResults.RegionID, imageResults.TypeShortName);
                        string fileExtension = ImageExporter.GetFileExtension(srcFileName);

                        if (fileExtension.Length == 0)
                          continue;

                        if (_filterCaptureProfiles != "" && !_filterCaptureProfiles.Contains(imageResults.CaptureProfileName.ToLower()))
                          continue;

                        srcFileName = srcFileName + fileExtension;
                        string destFileName = string.Format("{0}\\{6}_{1}_{2}_{3}_{4}{5}", 
                                                            folder, imageResults.WellLocation, ImageExporter.RemoveWhitespace(imageResults.CaptureProfileName), 
                                                            imageResults.HotKey, imageResults.ImageBatchID, fileExtension, imageResults.PlateBarcode);

                        try
                        {
                            File.Copy(srcFileName, destFileName);
                            streamWriter.WriteLine("\"{0}\",\"{1}\",Drop,{2:MM/dd/yy HH:mm:ss}", destFileName, imageResults.ScoreName, imageResults.DateImaged.Value);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                            Console.WriteLine("Unable to copy {0} {1} {2}", plateID, imageResults.WellLocation, imageResults.CaptureProfileName);
                        }
                        ++num;
                    }
                }
            }
            return num;
        }

    private string GetFolder(string destFolder, string scoreName)
    {
      var f = Path.Combine(destFolder, scoreName);

      if (!Directory.Exists(f))
        Directory.CreateDirectory(f);

      return f;
    }

    private static string GetFileExtension(string fileName)
        {
            ImageCodec imageCodec1 = (ImageCodec)new DotNetJpeg411ImageCodec();
            if (File.Exists(fileName + imageCodec1.Extension))
                return imageCodec1.Extension;
            foreach (ImageCodec imageCodec2 in (IEnumerable)ImageCodecs.Instance.imageCodecs.Values)
            {
                if (File.Exists(fileName + imageCodec2.Extension))
                    return imageCodec2.Extension;
            }
            return string.Empty;
        }

        private static DateTime? GetDispenseDate(long plateID)
        {
            return RockMakerDB.Instance.Plates.Where<Plate>(p => p.ID == plateID).Select<Plate, DateTime?>(p => p.DateDispensed).First<DateTime?>();
        }

        private static int GetLatestImageBatchID(List<ImageResults> imageList, int imageBatchIdx)
        {
            HashSet<int> source = new HashSet<int>();
            foreach (ImageResults image in imageList)
                source.Add(image.ImageBatchID);
            List<int> list = source.ToList<int>();
            list.Sort((Comparison<int>)((a, b) => -a.CompareTo(b)));
            return imageBatchIdx < list.Count ? list[imageBatchIdx] : list.Count - 1;
        }

        private static string RemoveWhitespace(string str)
        {
            return string.Join("", str.Split((string[])null, StringSplitOptions.RemoveEmptyEntries));
        }

        private IQueryable<ImageResults> GetImages(long plateID)
        {
            RockMakerEntities instance = RockMakerDB.Instance;

            var list = from ibwds in instance.ImageBatchWellDropScores
                       join wd in instance.WellDrops on ibwds.WellDropID equals wd.ID
                       join w in instance.Wells on wd.WellID equals w.ID
                       join p in instance.Plates on w.PlateID equals p.ID
                       join wds in instance.WellDropScores on ibwds.WellDropScoreID equals wds.ID
                       join wdsg in instance.WellDropScoreGroups on wds.WellDropScoreGroupID equals wdsg.ID
                       join ib in instance.ImageBatches on ibwds.ImageBatchID equals ib.ID
                       join cr in instance.CaptureResults on ib.ID equals cr.ImageBatchID
                       join r in instance.Regions on wd.ID equals r.WellDropID
                       join cpv in instance.CaptureProfileVersions on cr.CaptureProfileVersionID equals cpv.ID
                       join cp in instance.CaptureProfiles on cpv.CaptureProfileID equals cp.ID
                       join i in instance.Images on cr.ID equals i.CaptureResultID
                       join ity in instance.ImageTypes on i.ImageTypeID equals ity.ID
                       join ist in instance.ImageStores on i.ImageStoreID equals ist.ID
                       join it in instance.ImagingTasks on ib.ImagingTaskID equals it.ID
                       where cr.RegionID == r.ID &&
                             ity.ShortName == "ef" &&
                             wdsg.Name.ToLower() == _scoreGroupName &&
                             p.ID == plateID
                       select new ImageResults()
                       {
                           CaptureProfileName = cp.Name,
                           BasePath = ist.BasePath,
                           PlateID = p.ID,
                           WellNumber = w.WellNumber,
                           DropNumber = wd.DropNumber,
                           ImageBatchID = ibwds.ImageBatchID,
                           RegionID = r.ID,
                           CaptureProfileID = cp.ID,
                           TypeShortName = ity.ShortName,
                           PlateBarcode = p.Barcode,
                           ScoreName = wds.Name,
                           ScoreGroupName = wdsg.Name,
                           ScoreType = ibwds.ScoreType,
                           DateImaged = it.DateImaged,
                           WellLocation = w.RowLetter + w.ColumnNumber,
                           HotKey = wds.HotKey
                       };

            return list;
        }
    }
}
