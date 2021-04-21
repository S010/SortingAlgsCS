using System;
using Management;
namespace Helpers
{
    public class Merging 
    {
      public int[] returnMergedArray(int[] arrayOne , int[] arrayTwo)
      {
        int[] newArray  = new int[arrayOne.Length+arrayTwo.Length];
        Array.Copy(arrayOne,newArray,arrayOne.Length);
        Array.Copy(arrayTwo,0,newArray,arrayOne.Length,arrayTwo.Length);
        return newArray;
      }
    }
}