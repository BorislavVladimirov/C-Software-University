using NeedForSpeed.Cars;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar sportCar = new SportCar(240, 50.5);

            System.Console.WriteLine(sportCar.FuelConsumption); 
        }
    }
}
