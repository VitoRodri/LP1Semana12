using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private T z;
        private T x;
        private T y;

        public Guarda3()
        {
            z=default;
            x=default;
            y=default;
        }
        public T GetItem(int i)
        {
            if ((i<0) | (i>2))
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void SetItem(int i, T item)
        {
            item=i;
        }
    }
}