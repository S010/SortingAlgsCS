using System;

namespace Program
{
    class Sorting
    {
        public int Partition(int[] arr, int left , int right)
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
        public void quickSort(int[] arr, int first, int last)
        {
            Console.WriteLine("Quick sorting");
            if(first < last)
            {
                int pivot = Partition(arr,first,last);
                if(pivot>1)
                {
                    quickSort(arr,first,pivot-1);
                }
                if(pivot+1<last)
                {
                    quickSort(arr,pivot+1,last);
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