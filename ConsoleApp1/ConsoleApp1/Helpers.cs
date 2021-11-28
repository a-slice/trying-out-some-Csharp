using System;
using System.Collections.Generic;
using System.Text;

namespace csharpProblems
{
    public static class Helpers
    {
        public static void Switch<T>(this IList<T> array, int index1, int index2)
        {
            var temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

    }
}
