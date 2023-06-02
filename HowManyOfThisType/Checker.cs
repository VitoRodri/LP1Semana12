using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowManyOfThisType
{
    public static class Checker
    {
        public static int HowManyOfType<T>(IEnumerable<object> items)
        {
            int number=0;

            foreach(IEnumerable<object> item in items)
            {
                number++;
            }
            return number;
        }
    }
}