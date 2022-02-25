using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar car = new SportCar(100, 100);
            car.Drive(12);
            Console.WriteLine(car.Fuel);
        }
    }
}
