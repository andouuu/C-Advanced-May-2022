using System;
using System.Collections.Generic;
using System.Text;


namespace CarManufacturer
{ 
    class Car
    {
        // TODO: define the Car class members here … 
        private string make;
        private string model;
        private int year;
        //make: string
        //model: string
        //year: int
        //fuelQuantity: double
        private double fuelQuantity;
        //fuelConsumption: double
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { year = value; }
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public Tire[] Tires
        {
            get { return this.tires; }
            set { this.tires = value; }
        }
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
        public Car(string make, string model, int year)
        :this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) 
        : this(make, model, year)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) 
        : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public void Drive(double distance)
        {
            double fuelLeft = FuelQuantity - (FuelConsumption * distance);
            if (fuelLeft<0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                FuelQuantity -= (FuelConsumption * distance);
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}"+ "\r\n"+$"Model: {this.Model}" +$"\r\n"+$"Year: {this.Year}"+$"\r\n"+$"Fuel: {this.FuelQuantity:F2}";
        }
    }

}
