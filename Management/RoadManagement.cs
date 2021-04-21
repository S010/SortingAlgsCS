using System;

using System.Collections.Generic;
using Models;

namespace Management
{
    public class RoadManagement 
    {
      public List<Road> Roads {get; set;}

      public Road SelectedRoad {get; set;}
      public RoadManagement(FileManagement fileMang)
      {
        Roads = LoadRoads(fileMang);
        SelectedRoad = Roads[0];
      }
      public List<Road> LoadRoads(FileManagement fileMang)
      {
        List<Road> Roads = new List<Road>();

        foreach (var item in fileMang.Files)
        {
          Road road = new Road();
          road.Name = item.Name;
          road.Array = Array.ConvertAll(fileMang.GetContentsOfFile(fileMang.GetFile(fileMang.Files,item.Name)),int.Parse);
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