using System;
using System.Collections.Generic;

namespace Searching
{
    public class SearchingAlgs 
    {
        public int count { get; set; }
        public List<int> indexs = new List<int>();

        public void returnPositions()
        {
          if(indexs.Count != 0)
          {
            Console.WriteLine("Value found at the positions:");
            foreach (var item in indexs)
            {
                Console.Write($"  {item}  ");
            }
            Console.WriteLine($"It took {count} steps");
          }
          else
          {
            Console.WriteLine("Not found");
          }
            
        }
    }
}