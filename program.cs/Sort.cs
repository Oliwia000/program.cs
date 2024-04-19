using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.cs
{
    internal class Sort
    {
        private int[] t = new int[10];
        public Sort()
        {
            Console.WriteLine("Podaj 10 liczb całkowitych");
            int licznik = 0;
            do
            {
                Console.WriteLine((licznik + 1).ToString() + ":");
                t[licznik] = int.Parse(Console.ReadLine());
                licznik++;
            } while (licznik < 10);

        }
    }

}