using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("ABC123");
            var regno = vehicle.RegNo;

            Vehicle bike = new Bicycle("BBB321");
            vehicle.Drive();
            bike.Drive();

            Console.WriteLine(vehicle.Drive());
            Console.WriteLine("__________________________________"  );   
            Console.WriteLine(bike.Drive());
        }
    }
}
