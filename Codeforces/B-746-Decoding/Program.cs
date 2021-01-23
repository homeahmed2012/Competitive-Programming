using System;

namespace B_746_Decoding
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            string strLeft = "", strRight = "", strMid = "";
            if(n%2 != 0)
            {
                strMid = str[0]+"";
                str = str.Substring(1);
            }
            for (int i = 0; i < str.Length; i += 2)
            {
                strLeft += str[i];
                strRight += str[i+1];
            }
            var y = strLeft.ToCharArray();
            Array.Reverse(y);
            Console.WriteLine(string.Join("", y) + strMid + strRight);
        }
    }
}
