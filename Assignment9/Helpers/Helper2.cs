using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9.Helpers

{
    public static class Helper2<T>
    {
        // Question 10:

        public static int SearchArray(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (Equals(array[i], value))
                {
                    return i;
                }
            }

            return -1;
        }

        // Question 13:


        public static void ReplaceArray(
            T[] array, T oldValue, T newValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(
                    array[i], oldValue))
                {
                    array[i] = newValue;
                }
            }
        }

        // Question 15:
    

        public static int SearchArray(
            T[] array, Predicate<T> condition)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (condition(array[i]))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

