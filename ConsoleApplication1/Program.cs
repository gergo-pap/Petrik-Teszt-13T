using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] szam = new int [10];
            string bemenet;
            Console.WriteLine("Írj be 10 számot: ");
            for (int i = 0; i < 9; i++)
            {
                bemenet = Console.ReadLine();
                szam [i ]= int.Parse(bemenet);
            }
            Console.ReadKey();
        }
    }
}
