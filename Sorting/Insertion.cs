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
    public class Insertion : SortingAlg
    {
        public Insertion(int[] array , bool assending)
        {
            sortedArray = array;
            sort(sortedArray, assending);
            returnSortedArray();
            Console.WriteLine($"\nSteps:{count}");
        }
        private void sort(int[] array , bool assending)
        {
            if (assending)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    count++;
                    int currentVal = array[i];
                    int pos = i;
                    while(pos>0 && array[pos-1]>currentVal)
                    {
                        array[pos] = array[pos-1];
                        pos --;
                    }
                    array[pos] = currentVal;
                }   
            }
            else 
            {
                for (int i = 0; i < array.Length; i++)
                {
                    count++;
                    int currentVal = array[i];
                    int pos = i;
                    while(pos>0 && array[pos-1]<currentVal)
                    {
                        array[pos] = array[pos-1];
                        pos --;
                    }
                    array[pos] = currentVal;
                }
            }
            
        }
    }
}  