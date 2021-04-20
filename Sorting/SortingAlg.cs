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
      for (int i = 0; i < sortedArray.Length; i+=10)
      {
        Console.Write($"{sortedArray[i]}  ");
      }
    }  
  }   
}