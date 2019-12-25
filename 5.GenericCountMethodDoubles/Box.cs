using System;
using System.Collections.Generic;
using System.Text;

namespace _6.GenericCountMethodDoubles
{
    public class Box<T>
        where T : IComparable<T>
    {

        public T Value { get; set; }
        
        public Box(T value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{this.Value.GetType().FullName}: {this.Value}";
        }
    }

}
