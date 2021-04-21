namespace Sorting 
{
  public class Bubble : SortingAlg
  {
    public Bubble(int[] array,bool assending,bool display)
    {
      sortedArray = array;
      bubbleSort(sortedArray);
      if(display)
        returnSortedArray(assending);
    }
    public void bubbleSort(int[] array)
    {
      for (int i = 0; i <= array.Length - 2; i++)
      {
        count++;
        for (int n = 0; n <= array.Length - 2; n++)
        {
          if(array[n] > array[n + 1])
          {
            int t = array[n + 1];
            array[n + 1] = array[n];
            array[n] = t;
          }
        }
      }
    }  
  }
}