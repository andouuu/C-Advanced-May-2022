using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace P05P06.GenericCountMethodStringsAndDoubles
{
    public class Box<T>:IComparable<T> where T : IComparable<T>
    {
        public List<T> data;
        public T Element;
        public Box(T element)
        {
            Element=element;
        }
        public Box(List<T> data)
        {
            this.data=data;
        }
        public void SwapPlaces(int index1, int index2)
        {

            T elementIndex1=data[index1];
            data[index1]=data[index2];
            data[index2]=elementIndex1;
        }

        public int CompareTo(T other) => Element.CompareTo(other);

        public int CountGreaterElements<T>(List<T> list, T readline) where T : IComparable =>
            list.Count(x => x.CompareTo(readline) > 0);

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