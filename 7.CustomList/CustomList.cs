using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.CustomList
{
    public class CustomList<T> where T : IComparable<T>
    {
        IList<T> data;

        public CustomList()
        {
            this.data = new List<T>();
        }


        //Adds the given element to the end of the list
        public void Add(T element)
        {
            this.data.Add(element);
        }


        // removes the element at the given index
        public T Remove(int index)
        {
            T element = this.data[index];
            this.data.RemoveAt(index);

            return element;
        }

        //Prints if e list contains the given element, true or false
        public bool Compare(T element)
        {
            return this.data.Contains(element);
        }

        //Swap the elements at the given indexes
        public void Swap(int index1, int index2)
        {
            var element1 = this.data[index1];
            var element2 = this.data[index2];

            this.data[index1] = element2;
            this.data[index2] = element1;
        }

        public int CounterGreaterThan(T element)
        {
            int count = 0;
            for (int i = 0; i < this.data.Count; i++)
            {
                if (this.data[i].CompareTo(element) == 1)
                {
                    count++;
                }
            }

            return count;
        }

        public T Max()
        {
            return this.data.Max();
        }

        public T Min()
        {
            return this.data.Min();
        }

        public void Print()
        {
            foreach (var item in this.data)
            {
                Console.WriteLine(String.Join(Environment.NewLine, item));
            }
        }
    }
}
