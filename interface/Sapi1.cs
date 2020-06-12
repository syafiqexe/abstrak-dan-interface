using System;
using System.Collections.Generic;
using System.Text;

namespace abstraction.Interface

{
    public class Sapi : IHewan 
    {
        public override void makan()
        {
            Console.WriteLine("Sapi makan tumbuhan");
            Console.WriteLine("Sapi hewan herbivora");
            Console.WriteLine("Sapi hadalah hewan ternak");
        }
    }
}
