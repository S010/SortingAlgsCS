using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using RoadProgram.Models;
using RoadProgram.Management;
using RoadProgram.Sorting;

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
    public void SortingUI(FileManagement fileMang, RoadManagement roadMang)
    {
      bool EndWhile = false;
      while (EndWhile != true)
      {
          Console.WriteLine("=== Sorting ==");
          Console.WriteLine($"Selected file - {roadMang.SelectedRoad.Name} \n1 - Quick Sort\n2 - Insertion Sort\n3 - Heap Sort\nQ - Exit");
          switch (Console.ReadLine().ToLower())
          {

            case "1":
			  Console.WriteLine("==== Quick Sort ====");
              Quick quickSort = new Quick(roadMang.SelectedRoad.Array,Assending());
              break;
            
            case "2":
              Insertion insertionSort = new Insertion(roadMang.SelectedRoad.Array,Assending());
              break;
            
            case "3":
              Console.WriteLine("WIP");
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
    private bool Assending()
    {
      bool EndWhile = false;
      while(EndWhile!=true)
      {
        Console.WriteLine("Asending[1] or Decending?[2]");
        switch (Console.ReadLine().ToLower())
        {
          case "1":
            return true;
          case "2":
            return false;
          default:
            Console.WriteLine("Invalid Input");
            break;
        }
      }
      return true;
    }

  }
}