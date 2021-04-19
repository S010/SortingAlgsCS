using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using RoadProgram.Models;
using RoadProgram.Management;


namespace RoadProgram.Sorting
{
  public class SortingAlg 
  {
    public int count {get; set;}
    public int[] sortedArray {get; set;}

    public void returnSortedArray()
    {
      int i = 0 ;
      if(sortedArray.Length == 0)
      {
        Console.WriteLine("There isnt anything in the array");
      }
      else
      {
        foreach (var item in sortedArray)
        {
          i++;
          if (i % 10 == 0)
          {
            Console.WriteLine(item);
          }
        }
      }
    }  
  }   
}