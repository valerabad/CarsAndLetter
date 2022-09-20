using System;

namespace CarsAndLetter
{
    public class Car
    {
        public Guid Id { get; set; }
        public string NumberPlate { get; set; }
        public double FuelCapacity
        {
            get { return 100; }
            set { }
        }

        public Car(string NumberPlate, double FuelCapacity)
        {
            
        }
    }
}