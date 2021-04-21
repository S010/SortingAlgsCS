using System;
using Management;
using Helpers;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManagement fileMang = new FileManagement();
            RoadManagement roadMang = new RoadManagement(fileMang);
            UI ui = new UI();            
            //fileMang.GetFilePath();
            
            //roadMang.SelectRoad(Roads)
            while (true)
            {
                Console.WriteLine($"\n\n=== Sorting Roads ===\nDirectory : {fileMang.path}\nCurrent File : {roadMang.SelectedRoad.Name}\n");
                Console.WriteLine("1 - Sort Current File\n2 - Search Current File\n3 - Merge Current File With Another file \nS - Settings (Change Directory and Selected Road)\nQ - Quit");
                switch (Console.ReadLine().ToLower())
                {
                    case "1":
                        ui.SortingUI(fileMang,roadMang);
                        break;
                    case "2":
                        ui.SearchingUI(fileMang,roadMang);
                        break;
                    case "3":
                        ui.MergingUI(fileMang,roadMang);
                        break;
                    case "s":
                        ui.Settings(fileMang,roadMang);
                        break;
                    case "q":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Input a valid command");
                        break;
                }
                
            }
            //Console.WriteLine(selectedFile.Name);
        }
    }
}
