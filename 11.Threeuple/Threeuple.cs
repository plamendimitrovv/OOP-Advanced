using System;
using System.Collections.Generic;
using System.Text;

namespace _11.Threeuple
{

    public class Threeuple<T, U, P>
    {
        private T item1;
        private U item2;
        private P item3;

        public P Item3
        {
            get { return item3; }
            set { item3 = value; }
        }


        public T Item1
        {
            get { return item1; }
            set { item1 = value; }
        }

        public U Item2
        {
            get { return item2; }
            set { item2 = value; }
        }


        public Threeuple(T item1, U item2, P item3)
        {
            this.item1 = item1;
            this.item2 = item2;
            this.item3 = item3;
        }

        public override string ToString()
        {
            return $"{item1} -> {item2} -> {item3}";
        }
    }

}