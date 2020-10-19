using System;
using System.Linq;
using System.Collections.Generic;

namespace B_796_FindThePone
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] temp1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
 
            var holes = new HashSet<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
 
            int position = 1;
            for (int i = 0; i < temp1[2]; i++)
            {
                int[] swap = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (holes.Contains(position)) break;
                if (position == swap[0]) position = swap[1];
                else if (position == swap[1]) position = swap[0];
            } 
            
            Console.WriteLine(position);
        }
    }
}
