using System;

namespace CarsAndLetter
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Please enter count of cars: ");
            var countOfCars = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter capacity for car: ");
            var capacityForCar =Convert.ToDouble(Console.ReadLine());

            var carpool = new Carpool(countOfCars);
            var result = carpool.GetMaxDistance(capacityForCar);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}