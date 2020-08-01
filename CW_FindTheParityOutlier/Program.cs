using System;

namespace CW_FindTheParityOutlier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] exampleTest1 = { 160, 3, 1719, 19, 11, 13, -21 };
            Console.WriteLine("Hello World!");
            var a = new Kata();
            Console.WriteLine(a.Find(exampleTest1));
            Console.ReadKey();
        }
    }
}
