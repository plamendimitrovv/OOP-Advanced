using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _4.Froggy
{
    public class Lake : IEnumerable<int>
    {
        int[] stones;

        public Lake(int[] stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Length; i += 2)
            {
                yield return this.stones[i];
            }

            int length = this.stones.Length;
            int lastOddIndex = length % 2 == 0 ? length - 1 : length - 2;

            for (int i = lastOddIndex; i > 0; i -= 2)
            {
                yield return this.stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
