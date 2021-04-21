using System;

namespace Sorting
{
    public class Heap : SortingAlg
    {
      public Heap(int[] array, bool assending, bool display)
      {
          sortedArray = array; 
          heapSort(sortedArray);
          if(display)
            returnSortedArray(assending);
      }
      private void makeHeap(int[] array, int n, int i)
      {
          count++;
          int largest = i;
          int left = 2 * i + 1;
          int right = 2 * i + 2;
          if (left < n && array[left] > array[largest])
          {
              largest = left;
          }
          if (right < n && array[right] > array[largest])
          {
              largest = right;
          }

          if(largest != i)
          {
              int swap = array[i];
              array[i] = array[largest];
              array[largest] = swap;
              makeHeap(array,n,largest);
          }
      }
      private void heapSort(int[] array)
      {
          int n = array.Length; // Size of heap
          for (int i = n / 2; i >= 0; i--)
          {
              makeHeap(array,n,i);
          }
          for (int i = n-1; i > 0 ; i--)          
          {
              int temp = array[0];
              array[0] = array[i];
              array[i] = temp;
              makeHeap(array,i,0);
          }

      }
    }
} 