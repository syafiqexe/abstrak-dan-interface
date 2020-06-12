using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction.AbstractClass
{
    public class Sapi : Hewan
    {
        public override void makan()
        {
            Console.WriteLine("Sapi makan tumbuhan");
            Console.WriteLine("Sapi hewan herbivora");
            Console.WriteLine("Sapi hadalah hewan ternak");
        }
    }
}
