using System;
using System.Collections.Generic;
using System.Linq;

namespace B_16_BurglarandMatches
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0], m = nm[1];

            var contianers = new List<ValueTuple<int, int>>();

            int[] arr;
            for (int i = 0; i < m; i++)
            {
                arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                contianers.Add((arr[0], arr[1]));
            }
            contianers = contianers.OrderByDescending(c => c.Item2).ToList();
            int result = 0;
            foreach(var item in contianers)
            {
                int mn = Math.Min(n, item.Item1);
                result += mn * item.Item2;
                n -= mn;
                if(n <= 0) break;
            }
            Console.WriteLine(result);
        }
    }
}
