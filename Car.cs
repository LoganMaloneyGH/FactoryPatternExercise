using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEX
{
    public class Car : IVehicle 
    {
        public Car()
        {
            Console.WriteLine("building a new car!"); 
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving.");
        }
    }
}
