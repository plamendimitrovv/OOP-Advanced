using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace _2.Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {

        private List<T> data;
        public int CurrentIndex { get; set; }

        public ListyIterator(params T[] data)
        {
            this.CurrentIndex = 0;
            this.data = new List<T>(data);
        }


        public bool Move()
        {
            if (!HasNext())
            {
                return false;
            }
            this.CurrentIndex++;
            return true;
        }

        public void Print()

        {
            if (!this.data.Any())
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.data[CurrentIndex]);
        }

        public void PrintAll()
        {
            if (!this.data.Any())
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(string.Join(" ", this.data));
        }

        public bool HasNext()
        {
            bool result = CurrentIndex < this.data.Count - 1;
            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.data)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
