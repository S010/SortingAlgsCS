using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using RoadProgram.Models;
using RoadProgram.Management;

namespace RoadProgram.Helpers
{
  public class UI
  {
    public void Settings(FileManagement fileMang , RoadManagement roadMang)
    {
      bool EndWhile = false;
      while(EndWhile!=true)
      {
        Console.WriteLine("=== Settings ===");
        Console.WriteLine("1 - Change Directory\n2 - Change file\nQ - Back\n");
        switch (Console.ReadLine().ToLower())
        {
          case "1":
              fileMang.path = fileMang.GetFilePath();
              break;
          case "2":
              roadMang.SelectedRoad = roadMang.SelectRoad();
              break;
          case "q":
              EndWhile = true;
              break;
          default:
              Console.WriteLine("Invalid Input");
              break;
        }
      }
    }
  }
}