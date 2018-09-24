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
            Console.WriteLine("Írd be hány számot kérjen be a program: ");
            int darab = int.Parse(Console.ReadLine());
            int [] szam = new int [darab];
            string bemenet;
            Console.WriteLine("Írj be {0} darab számot: ", darab);
            for (int i = 0; i < darab; i++)
            {
                bemenet = Console.ReadLine();
                szam [i ]= int.Parse(bemenet);
            }
            Console.ReadKey();
        }
    }
}
