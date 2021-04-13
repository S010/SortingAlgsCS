using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManagement f = new FileManagement();
            Sorting s = new Sorting();
            string path = f.GetFilePath();
            List<FileInfo> files = f.GetFilesInPath(path);
            int[] Road1_256 = Array.ConvertAll(f.GetContentsOfFile(f.GetFile(files,"Road_1_256.txt")),int.Parse);
            int[] Road2_256 = Array.ConvertAll(f.GetContentsOfFile(f.GetFile(files,"Road_2_256.txt")),int.Parse);
            int[] Road3_256 = Array.ConvertAll(f.GetContentsOfFile(f.GetFile(files,"Road_3_256.txt")),int.Parse);
            s.quickSort(Road1_256,0,Road1_256.Length-1);
            foreach (var item in Road1_256)
            {
                Console.WriteLine(item);
            }

        }
    }
}
