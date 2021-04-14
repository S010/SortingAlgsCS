using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using RoadProgram.Models;
using RoadProgram.Management;
using RoadProgram.Helpers;
namespace RoadProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManagement fileMang = new FileManagement();
            Sorting sorting = new Sorting();
            RoadManagement roadMang = new RoadManagement(fileMang.Files);
            UI ui = new UI();            
            //fileMang.GetFilePath();
            
            //roadMang.SelectRoad(Roads)
            while (true)
            {
                Console.WriteLine($"\n\n=== Sorting Roads ===\nDirectory : {fileMang.path}\nCurrent File : {roadMang.SelectedRoad.Name}\n");
                Console.WriteLine("1 - Sort Current File\n2 - Search Current File\n3 - Merge Current File With Another file \nS - Settings (Change Directory and Selected Road)\nQ - Quit\n");
                switch (Console.ReadLine().ToLower())
                {
                    case "s":
                        ui.Settings(fileMang,roadMang);
                        break;
                    case "q":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
                
            }
            //Console.WriteLine(selectedFile.Name);
        }
    }
}
