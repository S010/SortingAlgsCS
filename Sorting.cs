using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using RoadProgram.Models;
using RoadProgram.Management;
namespace RoadProgram
{
    class Sorting
    {
        int count = new int();
        public int Partition(int[] arr ,bool ascending, int left , int right)
        {
            if(left > right) return -1;
            int end = left;
            int pivot = arr[right];
            for(int i = left; i<right;i++)
            {
                switch (ascending)
                {
                    case true :
                        if(arr[i] < pivot)
                        {
                            swap(arr,i,end);
                            end++;
                        }
                        break;
                    case false :
                        if(arr[i] > pivot)
                        {
                            swap(arr,i,end);
                            end++;
                        }
                        break;
                }
            }
            swap(arr,end,right);
            return end;
        }
        public void quickSort(int[] arr,bool ascending, int left , int right)
        {
            Console.WriteLine($"Quick sort iteration {count}");
            if(left < right)
            {
                int pivot = Partition(arr,ascending,left,right);
                if(pivot>1)
                {
                    count++;
                    quickSort(arr,ascending,left,pivot-1);
                }
                if(pivot+1<right)
                {
                    count++;
                    quickSort(arr,ascending,pivot+1,right);
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