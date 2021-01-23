using System;
using System.Linq;

namespace B_102_SumofDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int counter = 0;
            while(num.Length > 1)
            {
                num = num.Sum(i => i-'0').ToString();
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
