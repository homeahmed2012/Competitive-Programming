using System;

namespace B_78_EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string colors = "ROYGBIV";
            string result = "";
            for (int i = 0; i < n/7; i++)
            {
                result += colors;
            }
            result += colors.Substring(Math.Max(0, 4-(n%7)), n%7);

            Console.WriteLine(result);
        }
    }
}
