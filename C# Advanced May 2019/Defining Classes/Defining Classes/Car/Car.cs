namespace CarManufacturer
{
    public partial class StartUp
    {
        public class Car
        {
            private string make;
            private string model;
            private int year;
            private double fuelQuantity;
            private double fuelConsumption;

            public string Make { get; set; }

            public string Model { get; set; }

            public int Year { get; set; }

            public double FuelQuantity { get; set; }

            public double FuelConsumption { get; set; }

            public void Drive(double distance)
            {
                double fuelWasted = this.FuelQuantity - (distance * this.FuelConsumption);

                if (fuelWasted < 0)
                {
                    System.Console.WriteLine("Not enough fuel to perform this trip!");
                    return;
                }

                this.FuelQuantity = fuelWasted;
            }

            public string WhoAmI()
            {
               return $"Make: { this.Make}\nModel: { this.Model}\nYear: { this.Year}\nFuel: { this.FuelQuantity:F2}L";
            }
        }
    }
}
