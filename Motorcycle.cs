using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEX
{
   public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
            Console.WriteLine("building a new motorcycle!");
        }

        public void Drive()
        {
            Console.WriteLine($"Motorcycle is now driving. ");
        }
    }
}
