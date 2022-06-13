namespace DefiningClasses
{
    public class Engine
    {
        private int speed;

        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        private int power;

        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }
    }
}