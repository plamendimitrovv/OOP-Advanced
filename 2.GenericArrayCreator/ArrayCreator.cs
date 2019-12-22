using System;
using System.Collections.Generic;
using System.Text;

namespace _2.GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            T[] arr = new T[length];

            for (int index = 0; index < length; index++)
            {
                arr[index] = item; 
            }
                                 

            for (int index = 0; index < length; index++)
            {
                Console.WriteLine(arr[index]); 
            }

            return arr;
        }
    }
}
