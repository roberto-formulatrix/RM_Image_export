using RockMakerModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

namespace ImageAnalyzer
{
    internal class Program
    {
        private static readonly HashSet<string> folderTypes = new HashSet<string>()
        {
          "ProjectFolder",
          "ProjectsFolder",
          "Experiment",
          "Projects",
          "Project"
        };

        private static readonly HashSet<string> plateTypes = new HashSet<string>()
        {
          "ExperimentPlate"
        };

        private static void Main(string[] args)
        {
            if (args.Length == 1 && args[0] == "test")
                args = new string[2]
                {
                  "9079",
                  "C:\\PlateExport"
                };

            if (args.Length != 2)
            {
                Console.WriteLine("Usage: ExportImages barcode destination_folder");
                Console.WriteLine("Usage: ExportImages plate_id destination_folder");
                Console.WriteLine("Usage: ExportImages RM_folder destination_folder");
                return;
            }

            Console.WriteLine("Warning: this software is supplied in an as is fashion and is unsupported");
            Console.WriteLine("Copyright Formulatrix 2016");

            string srcDesc = args[0];
            string pathToRM = "C:\\Program Files (x86)\\Formulatrix\\RockMaker";
            string str = args[1];
            int imageBatchIdx = 0;

            if (!Directory.Exists(str))
                Directory.CreateDirectory(str);

            RockMakerDB.Connect(pathToRM);
            long plateID1;
            long[] plateIDs;

            if (Program.FindByPlateID(srcDesc, out plateID1))
                plateIDs = new long[1] { plateID1 };
            else if (Program.FindByBarcode(srcDesc, out plateID1))
                plateIDs = new long[1] { plateID1 };
            else if (!Program.FindPlatesUnderNode(srcDesc, out plateIDs))
                throw new Exception("Unable to find source: " + srcDesc);

            ImageExporter imageExporter = new ImageExporter(pathToRM, str);

            foreach (long cur_plateID in plateIDs)
            {
                Console.WriteLine("Copying Images for plate :" + srcDesc);
                Console.WriteLine("Images copied: " + (object)imageExporter.ExportPlate(cur_plateID, imageBatchIdx));
            }
        }

        private static bool FindByPlateID(string srcDesc, out long plateID)
        {
            plateID = -1L;

            if (!int.TryParse(srcDesc, out int id))
                return false;

            var source = from p in RockMakerDB.Instance.Plates where p.ID == id select p.ID;

            if (source.ToArray<long>().Length == 0)
                return false;

            plateID = source.First<long>();
            return true;
        }

        private static bool FindByBarcode(string srcDesc, out long plateID)
        {
            plateID = -1L;
            long[] array = (from p in RockMakerDB.Instance.Plates where p.Barcode == srcDesc select p.ID).ToArray();

            if (array.Length == 0)
                return false;
            plateID = array[0];
            return true;
        }

        private static bool FindPlatesUnderNode(string srcDesc, out long[] plateIDs)
        {
            plateIDs = (long[])null;
            if (!srcDesc.StartsWith("Projects\\"))
                srcDesc = "Projects\\" + srcDesc;

            string[] strArray = srcDesc.Split('\\');
            int? nodeID = new int?();
            var instance = RockMakerDB.Instance;

            foreach (string str in strArray)
            {
                string p = str;

                var source = from t in instance.TreeNodes where t.ParentID == nodeID && t.ParentID == nodeID && t.Name == p select t.ID;

                if (source.Count<int>() != 1)
                    return false;
                nodeID = new int?(source.First<int>());
            }
            plateIDs = Program.GetPlatesUnderNode(nodeID.Value).ToArray();
            return true;
        }

        private static List<long> GetPlatesUnderNode(int nodeID)
        {
            var instance = RockMakerDB.Instance;

            var queryable = from n in instance.TreeNodes where n.ParentID == nodeID select n;

            List<long> longList = new List<long>();

            foreach (TreeNode treeNode in (IEnumerable<TreeNode>)queryable)
            {
                TreeNode c = treeNode;

                if (Program.folderTypes.Contains(c.Type))
                    longList.AddRange((IEnumerable<long>)Program.GetPlatesUnderNode(c.ID));
                else if (Program.plateTypes.Contains(c.Type))
                {
                    var source = from p in instance.Plates where p.TreeNodeID == c.ID select p;
                    longList.Add(source.First<Plate>().ID);
                }
            }

            return longList;
        }
    }
}
