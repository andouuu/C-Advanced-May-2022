using System.Collections.Generic;

namespace P03P04.GenericSwapMethodStringAndInteger
{
    public class Box<T>
    {
        public List<T> data;

        public Box()
        {
            data=new List<T>();
        }
        public void SwapPlaces(int index1, int index2)
        {

            T elementIndex1=data[index1];
            data[index1]=data[index2];
            data[index2]=elementIndex1;
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