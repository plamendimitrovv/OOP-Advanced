using System;
using System.Collections.Generic;
using System.Text;
   public class Box<T>
    {
        private readonly List<T> data; 

        public Box()
        {
            this.data = new List<T>();
        }

     //   public IReadOnlyCollection<T> Data => this.data.AsReadOnly();
        public int Count => this.data.Count;


        // Adding should add on top of its contents
        public void Add(T element)
        {
            this.data.Add(element);
        }


        //Remove should get the topmost element
        public T Remove()
        {
            T element = this.data[Count - 1];
            this.data.RemoveAt(this.data.Count - 1);

            return element;
        }


        // print the remaning elements
        //public void Print()
        //{
        //    foreach (var item in data)
        //    {
        //        Console.WriteLine(item.ToString());
        //    } 
        //}

    }

