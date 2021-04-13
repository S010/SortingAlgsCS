using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Program
{
    class Program
    {
        private static List<Road> LoadRoads(List<FileInfo> files)
        {
            FileManagement f = new FileManagement();
            List<Road> Roads = new List<Road>();
            foreach (var item in files)
            {
                Road road = new Road();
                road.Name = item.Name;
                road.Array = Array.ConvertAll(f.GetContentsOfFile(f.GetFile(files,"Road_1_256.txt")),int.Parse);
                Roads.Add(road);
                Console.WriteLine($"Loaded {road.Name} ...");
            }
            return Roads;
        }
        static void Main(string[] args)
        {
            FileManagement f = new FileManagement();
            Sorting s = new Sorting();
            string path = f.GetFilePath();
            List<FileInfo> files = f.GetFilesInPath(path);
            List<Road> Roads = new List<Road>(LoadRoads(files));
            Road selectedFile = null;
        }
    }
}
