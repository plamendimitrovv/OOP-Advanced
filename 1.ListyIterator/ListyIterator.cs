using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _1.ListyIterator
{
    public class ListyIterator<T>
    {

        private List<T> data;
        private int internalIndex;

        public ListyIterator(params T[] data)
        {
            this.internalIndex = 0;
            this.data = new List<T>(data);
        }

      
        public bool Move ()
        {
            if (!HasNext())
            {
                return false; 
            }
            this.internalIndex++;
            return true; 
        }

        public void Print ()

        {
            if (!this.data.Any())
            {
                throw new InvalidCastException("Invalid Operation!");
            }

            Console.WriteLine(this.data[internalIndex]);
        }

        public bool HasNext()
        {
            bool result = internalIndex < this.data.Count - 1;
            return result;
        }

    }
}
