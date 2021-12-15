using System;

namespace FactoryPatternEX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how mnany wheels will you have?");
            string numberOfWheels = Console.ReadLine();

            IVehicle vehicle1 = VehicleFactory.GetVehicle(numberOfWheels);

            vehicle1.Drive(); 

        }
    }
}
