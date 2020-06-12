using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using abstraction.AbstractClass;

namespace abstrak
{
    class Program
    {
        static void Main(string[] args)
        {
            Hewan hewan;

            hewan = new Singa();
            hewan.makan();


            Console.WriteLine();
            hewan = new Sapi();
            hewan.makan();

            Console.ReadKey();

        }
    }
}
