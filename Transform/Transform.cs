using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static List<int> Map(this int[] listi,Func<int,int> map)
        {
            List<int> op = new List<int>();
            foreach(int i in listi)
            {
                op.Add(map(i));
            }
            return op;
        }
    }
}
