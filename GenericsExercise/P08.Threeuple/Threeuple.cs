namespace P08.Threeuple
{
    public class Threeuple<T1,T2,T3>
    {
        private T1 item1;
        private T2 item2;
        private T3 item3;

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
        public T3 Item3
        {
            get { return this.item3; }
            set { this.item3 = value; }
        }

        public Threeuple(T1 item1, T2 item2, T3 item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }
    }
}