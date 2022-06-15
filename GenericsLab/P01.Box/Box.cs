using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> data;
        public Box()
        {
            data=new List<T>();
        }
        public int Count => this.data.Count;
        public void Add(T element)
        {
            this.data.Add(element);
        }
        public T Remove()
        {
            if (this.data.Count==0)
            {
                throw new InvalidOperationException("The box is empty.");
            }
            var rem = this.data.Last();
            this.data.RemoveAt(this.data.Count-1);
            return rem;
        }
        
    }
}