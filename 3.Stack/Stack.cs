using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private readonly List<T> data;

        public Stack(params T[] data)
        {
            this.data = new List<T>(data);
        }

        public void Push(T element)
        {
            data.Add(element);
        }

        public void Pop()
        {
            if (!data.Any())
            {
                throw new InvalidOperationException("No elements");
            }
            this.data.RemoveAt(this.data.Count - 1);
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.data.Count - 1; i >= 0; i--)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator(); 
        }
    }
}
