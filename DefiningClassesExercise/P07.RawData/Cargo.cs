namespace DefiningClasses
{
    public class Cargo
    {
        private string type;

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        private int weight;

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
    }
}