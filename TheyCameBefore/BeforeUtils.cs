using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<object> items, T item1) where T:IComparable<T>
        {
            

            T.Sort(CompareTo(item1));
            return T;
        }
        private int CompareTo( object item1)
        {
            return items.CompareTo(item1);
        }

        
      
        
    }
}