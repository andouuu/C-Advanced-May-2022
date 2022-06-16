using System.Collections.Generic;

namespace P01.GenericBoxOfString
{
    public class Box<T>
    {
        public List<T> data;

        public Box()
        {
            data=new List<T>();
        }

        public override string ToString()
        {
            string output = string.Empty;
            foreach (T item in data)
            {
                output += $"{item.GetType()}: {item}" + "\r\n";
            }
            return output;
        }
    }
}