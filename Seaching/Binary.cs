using System;
using Sorting;
namespace Searching
{
    public class Binary : SearchingAlgs
    {
      public Binary(int[] array, int searchInt)
      {
        Quick quickArray = new Quick(array,true,false);
        int [] sorted = quickArray.sortedArray;
        int result = search(sorted,searchInt);
        if(result != -1)
          indexs.Add(result);
        returnPositions();
      }

      public int search(int[] array,int searchInt)
      {
        int min = 0;
        int max = array.Length -1;
        while (min <= max)
        {
          count++;
          int mid = (min + max) / 2;
          if(searchInt == array[mid])
          {
            return(++mid);
          }
          if(searchInt < array[mid])
          {
            max = mid -1;
          }
          else
          {
            min = mid+1;
          }
        }
        return -1;  
      }
    }
}
