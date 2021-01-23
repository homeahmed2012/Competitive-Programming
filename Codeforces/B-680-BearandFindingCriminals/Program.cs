using System;
using System.Linq;

namespace B_680_BearandFindingCriminals
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] na = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = na[0], a = na[1]-1;
            int[] cities = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int result = cities[a];
            for (int i = a-1, j = a+1; i >= 0 || j < n; i--, j++)
			{
                if (i >= 0 && j < n)
                    result += (cities[i] == 1 && cities[j] == 1)? 2 : 0;
                else 
                {
                    if(i >= 0) result += cities[i];
                    else result += cities[j];
                }

			}
            Console.WriteLine(result);
        }
    }
}
