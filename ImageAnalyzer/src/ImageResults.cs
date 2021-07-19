using System;

namespace ImageAnalyzer
{
    internal class ImageResults
    {
        public string BasePath;
        public long PlateID;
        public int WellNumber;
        public int DropNumber;
        public int ImageBatchID;
        public long RegionID;
        public int CaptureProfileID;
        public string CaptureProfileName;
        public string TypeShortName;
        public string PlateBarcode;
        public string ScoreName;
        public string ScoreGroupName;
        public int ScoreType;
        public DateTime? DateImaged;
        public string WellLocation;
        public string HotKey;
    }
}
