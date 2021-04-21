using System;
using Management;
using Sorting;
using Searching;
namespace Helpers
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
        Console.WriteLine("\n=== Sorting ===");
        Console.WriteLine($"Selected file - {roadMang.SelectedRoad.Name} \n1 - Quick Sort\n2 - Insertion Sort\n3 - Heap Sort\n4 - Bubble Sort\nQ - Exit");
        switch (Console.ReadLine().ToLower())
        {
          case "1":
            Console.WriteLine("==== Quick Sort ====");
            Quick quickSort = new Quick(roadMang.SelectedRoad.Array,Assending(),true);
            break;
          case "2":
            Insertion insertionSort = new Insertion(roadMang.SelectedRoad.Array,Assending(),true);
            break;
          case "3":
            Heap heapSort = new Heap(roadMang.SelectedRoad.Array,Assending(),true);
            break;
          case "4":
            Bubble bubbleSort = new Bubble(roadMang.SelectedRoad.Array,Assending(),true);
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
    
    public void SearchingUI(FileManagement fileMang, RoadManagement roadMang)
    {
      bool EndWhile = false;
      while(EndWhile!=true)
      {
        Console.WriteLine("\n=== Searching ===");
        Console.WriteLine($"Selected File - {roadMang.SelectedRoad.Name}\n1 - Linear\n2 - Binary\nQ - Exit");
        switch (Console.ReadLine().ToLower())
        {
          case "1":
            Linear linearSearch = new Linear(roadMang.SelectedRoad.Array,getSelectedNumber());
            break;

          case "2":
            Binary binarySearch = new Binary(roadMang.SelectedRoad.Array,getSelectedNumber());
            break;

          case "q":
            EndWhile = true;
            break;

          default:
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

    private int getSelectedNumber()
    {
      while (true)
      {
        Console.WriteLine("Please input a number");
        string input = Console.ReadLine();
        try
        {
          int result  = int.Parse(input);
          return result;
        }
        catch(FormatException)
        {
          Console.WriteLine("Please input a number");
        }
      }
    }
  }
}