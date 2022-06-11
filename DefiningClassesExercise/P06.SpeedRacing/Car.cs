namespace P06.SpeedRacing
{
    public class Car
    {
        private string model;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        private double fuelAmount;

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        private double fuelConsumptionPerKilometer;

        public double FuelConsumptionPerKilometer
        {
            get { return this.fuelConsumptionPerKilometer; }
            set { this.fuelConsumptionPerKilometer = value; }
        }
        private double travelledDistance;

        public double TravelledDistance
        {
            get { return this.travelledDistance; }
            set { this.travelledDistance = value; }
        }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer, double travelledDistance)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = travelledDistance;
        }
        public bool CanItDrive(double distance)
        {
            bool canItDrive = !(FuelAmount - fuelConsumptionPerKilometer * distance < 0);
            return canItDrive;
        }
    }
}