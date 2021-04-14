using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using RoadProgram.Models;

namespace RoadProgram.Management
{
    public class RoadManagement 
    {
      public List<Road> Roads {get; set;}

      public Road SelectedRoad {get; set;}
      public RoadManagement(List<FileInfo> files)
      {
        Roads = LoadRoads(files);
        SelectedRoad = Roads[0];
      }

      public List<Road> LoadRoads(List<FileInfo> files)
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
      public Road SelectRoad()
      {
        while(true)
        {
          Console.WriteLine("Please select the file you would like to use");
          foreach (var item in Roads)
          {  
            Console.WriteLine($"{Roads.IndexOf(item)+1} : {item.Name}");
          }
          string choice = Console.ReadLine();
          if(int.Parse(choice) > Roads.Count+1)
          {
            Console.WriteLine("Input Invalid");
          }
          else
          {
            return Roads[int.Parse(choice)-1];
          }
          ;
        }

        
      }
      
    }
}