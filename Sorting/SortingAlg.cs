using System;

namespace Sorting
{
  public class SortingAlg 
  {
    public int count {get; set;}
    public int[] sortedArray {get; set;}

    public void returnSortedArray(bool assending)
    {
      Console.WriteLine("=== RESULT ===");
      int nthVal = 0;
      if(sortedArray.Length >= 2048){nthVal = 50;}
      else{nthVal = 10;};
      if(!assending)
      {
        for(int n = 0; n < sortedArray.Length/2; n++)
        {
          int temp = sortedArray[n];
          sortedArray[n] = sortedArray[sortedArray.Length - n- 1];
          sortedArray[sortedArray.Length- n -1] = temp;
        }
      }
      for (int i = 0; i < sortedArray.Length; i+=nthVal)
      {
        Console.Write($"{sortedArray[i]}  ");
      }
      Console.WriteLine($"Steps:{count}");  
    }  
  }   
}