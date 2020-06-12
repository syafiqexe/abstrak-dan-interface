using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using abstraction.Interface;

namespace abstrak
{
    class Program1
    {
        static void Main(string[] args)
        {
            IHewan hewan;

            hewan = new Singa();
            hewan.makan();


            Console.WriteLine();
            hewan = new Sapi();
            hewan.makan();

            Console.ReadKey();

        }
    }
}