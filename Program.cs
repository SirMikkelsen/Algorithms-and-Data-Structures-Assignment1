using System;
using System.IO;

namespace Assignment1
{
    class Program
    {
        private static string[] _lines = System.IO.File.ReadAllLines(@"C:\Users\Gordon\Source\Repos\Assignment1\tinyUF.txt");

        static void Main(string[] args)
        {
            QuickUnion qu = new QuickUnion(10);

            WeightedUnion wu = new WeightedUnion(10);

            foreach(string _line in _lines)
            {
                string[] split = _line.Split(' ');

                if(split.Length > 1) {

                    int num1 = Int32.Parse(split[0]);
                    int num2 = Int32.Parse(split[1]);
                    qu.Union(num1, num2);
                    Console.WriteLine(qu.ToString());
                }

            foreach (string _line in _lines)
            {
                string[] split = _line.Split(' ');

                if (split.Length > 1)
                {

                    int num1 = Int32.Parse(split[0]);
                    int num2 = Int32.Parse(split[1]);
                    wu.union(num1, num2);
                    Console.WriteLine(wu.ToString());
                }
            }

        }
    }
}
