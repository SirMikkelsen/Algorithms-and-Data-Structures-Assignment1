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

            foreach(string _line in _lines)
            {
                int[] split = _line.Split(' ');
                if(split.Length > 1) {
                    qu.Union(split[0], split[1]);
                    Console.WriteLine(qu.ToString());
                }
            }
            //while (a! == 0)
        }
    }
}
