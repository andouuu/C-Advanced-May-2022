namespace P07.Tuple
{
    public class Tuple<T1, T2>
    {
        private T1 item1;
        private T2 item2;

        public T1 Item1
        {
            get { return this.item1; }
            set { this.item1 = value; }
        }

        public T2 Item2
        {
            get { return this.item2; }
            set { this.item2 = value; }
        }

        public Tuple(T1 item1, T2 item2)
        {
            Item1= item1;
            Item2= item2;
        }

    }
}