using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static List<TResult> Map<T, TResult>(this IEnumerable<T> listi,Func<T,TResult> map)
        {
            return listi.Select(map).ToList();
        }
    }
}
