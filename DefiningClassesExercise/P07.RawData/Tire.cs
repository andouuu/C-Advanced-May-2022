namespace DefiningClasses
{
    public class Tire
    {
        private int age;

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        private double pressure;

        public double Pressure
        {
            get { return this.pressure; }
            set { this.pressure = value; }
        }
        public Tire(int age, double pressure)
        {
            Age = age;
            Pressure = pressure;
        }
    }
}