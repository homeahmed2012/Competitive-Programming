using System;
using System.Linq;
using System.Collections.Generic;

namespace B_47_Coins
{
    class Program
    {
        static List<string> check(string rule, List<string> all)
        {
            List<string> res = new List<string>();
            foreach (var item in all)
            {
                if(rule[1] == '>' && item.IndexOf(rule[0]) > item.IndexOf(rule[2])) res.Add(item);
                else if(rule[1] == '<' && item.IndexOf(rule[0]) < item.IndexOf(rule[2])) res.Add(item);
            }
            return res;
        }
        static void Main(string[] args)
        {
            var weights = new string[3];
            for (int i = 0; i < 3; i++)
            {
                weights[i] = Console.ReadLine();
            }
            List<string> allStr = new List<string> { "ABC", "ACB", "BAC", "BCA", "CAB", "CBA" };

            foreach (var item in weights)
            {
                allStr = check(item, allStr);
            }
            if (allStr.Count == 0) Console.WriteLine("Impossible");
            else Console.WriteLine(allStr.First());
        }
    }
}
