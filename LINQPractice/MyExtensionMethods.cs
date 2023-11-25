using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    public static class MyExtensionMethods
    {
        public static TSource FindBeforeLastItem<TSource>(this IEnumerable<TSource> source) 
        {            
            if (source == null) 
            {
                throw new ArgumentNullException(nameof(source));
            }
            return source.Reverse().Skip(1).FirstOrDefault();
        }
    }
}


