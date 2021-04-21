using System;

namespace Searching
{
  public class Linear : SearchingAlgs 
  {
    public Linear(int[] array, int searchInt)
    {
      search(array, searchInt);
      returnPositions();
    }
    private void search(int[] array,int searchInt)
    {
      for (int i = 0; i < array.Length; i++)
      {
        count++;
        if (array[i] == searchInt)
        {
          indexs.Add(i);
        }
      }
    }  
  }
}