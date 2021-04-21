using System;


namespace Sorting
{
    public class Insertion : SortingAlg
    {
        public Insertion(int[] array , bool assending,bool display)
        {
            sortedArray = array;
            sort(sortedArray);
            if(display)
                returnSortedArray(assending);
        }
        private void sort(int[] array)
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
    }
}  