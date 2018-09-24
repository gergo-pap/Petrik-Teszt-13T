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
            int [] tomb = new int [darab];
            string bemenet;
            Console.WriteLine("Írj be {0} darab számot: ", darab);
            for (int i = 0; i < darab; i++)
            {
                bemenet = Console.ReadLine();
                tomb [i ]= int.Parse(bemenet);
            }
            int max = tomb[0];
            int min = tomb[0];
            for (int i = 0; i < darab; i++)
            {
                if (tomb[i] > max)
                {
                    max = tomb[i];
                }
                else if (tomb[i] < max)
                {
                    min = tomb[i];
                }
            }
            Console.WriteLine("Max elem: {0}, min elem: {1}",max,min);


            Console.ReadKey();
        }
    }
}
