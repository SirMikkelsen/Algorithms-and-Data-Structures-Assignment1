using System;
using System.IO;

namespace Assignment1
{
    class Program
    {
        private static string[] _lines = System.IO.File.ReadAllLines(@"C:\Users\Gordon\Source\Repos\Assignment1\tinyUF.txt");

        static void Main(string[] args)
        {



            
            foreach(string _line in _lines) 
            {
                
            }
            
            QuickUnion qu = new QuickUnion(10);
            qu.Union(7, 8);
            Console.WriteLine(qu.ToString());
            
            qu.Union(5, 6);
            Console.WriteLine(qu.ToString());
          


            //while (a! == 0)
        }
    }
}
