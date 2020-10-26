using System;
using System.Linq;

namespace B_66_BetyaAndCountryside
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sum = new int[n];
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                if(i > 0 && arr[i] >= arr[i-1]) c++;
                else c = 1;

                sum[i] = c;
            }

            int mx = 0;
            c = 0;
            for (int i = n-2; i >= 0; i--)
            {
                if(arr[i] >= arr[i+1]) c++;
                else c = 0;
                mx = Math.Max(mx, c+sum[i]);
            }
            mx = Math.Max(mx, sum[n-1]);
            Console.WriteLine(mx);
        }
    }
}
