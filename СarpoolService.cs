namespace CarsAndLetter
{
    public interface IСarpoolService
    {
        
    }

    public class Carpool : IСarpoolService
    {
        private readonly int countOfCars;
        public Carpool(int countOfCars)
        {
            this.countOfCars = countOfCars;
        }
        
        public double GetMaxDistance(double distanceForOneCar)
        {
            var maxDistance = 0d;
            
            for (var i = countOfCars; i >= 1; i--)
            {
                maxDistance += distanceForOneCar / i;
            }

            return maxDistance;
        }
    }
}