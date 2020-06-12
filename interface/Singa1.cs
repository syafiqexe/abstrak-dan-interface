using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction.Interface
{
    public class Singa : IHewan
    {
        public override void makan()
        {
            Console.WriteLine("Singa makan daging");
            Console.WriteLine("Singa hewan karnivora");
            Console.WriteLine("Singa hewan yang buas");
        }
    }
}