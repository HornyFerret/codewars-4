using System;

namespace codewars_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1234";
            int w = StringToNumber(str);
            Console.WriteLine(w);
        }
        public static int StringToNumber(String str)
        {
            //TODO: Convert str into a number
            int n = Int32.Parse(str);
            return n;
        }
    }
}
