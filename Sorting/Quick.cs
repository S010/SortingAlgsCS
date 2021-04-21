using System;

namespace Sorting
{
    public class Quick : SortingAlg
    {
        public Quick(int[] array, bool assending, bool display)
        {
            sortedArray = array;
            recurSort(sortedArray,0,sortedArray.Length-1);
            if(display)
                returnSortedArray(assending);
        }

        private int Partition(int[] arr , int left , int right)
        {
            if(left > right) return -1;
            int end = left;
            int pivot = arr[right];
            for(int i = left; i<right;i++)
            {
                if(arr[i] < pivot)
                {
                    swap(arr,i,end);
                    end++;
                }
            }
            swap(arr,end,right);
            return end;
        }
        private void recurSort(int[] arr, int left , int right)
        {
            if(left < right)
            {
                int pivot = Partition(arr,left,right);
                if(pivot>1)
                {
                    count++;
                    recurSort(arr,left,pivot-1);
                }
                if(pivot+1<right)
                {
                    count++;
                    recurSort(arr,pivot+1,right);
                }
            }
        }
        private void swap (int[] arr , int left , int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp; 
        }
    }
}
