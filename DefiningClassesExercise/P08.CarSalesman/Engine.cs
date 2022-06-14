namespace DefiningClasses
{
    public class Engine
    {
        //Model: a string property
        public string Model { get; set; }
        //Power: an int property
        public int Power { get; set; }
        //Displacement: an int property, it is optional
        public int Displacement = 0;
        //Efficiency: a string property, it is optional
        public string Efficiency = null;
    }
}