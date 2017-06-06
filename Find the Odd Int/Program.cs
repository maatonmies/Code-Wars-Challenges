//Given an array, find the int that appears an odd number of times.

//There will always be only one integer that appears an odd number of times.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
  class Kata
  {
    public static int find_it(int[] seq) 
      {
        var dict = new Dictionary<int,int>();

        Array.ForEach(seq, x=>
        {                  
         if(!dict.ContainsKey(x))
             dict.Add(x, 1);
         else
             dict[x]++;
        });
        
        return dict.Where(x => x.Value % 2 > 0).First().Key;
        
       }       
   }
}