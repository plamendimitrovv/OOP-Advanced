using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _1.Library
{
    public class Library
    {
        private List<Book> books { get; set; }

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerable<Book> GetEnumerator()
        {
            for (int i = 0; i < this.books.Count; i++)
            {
                yield return this.books[i]; 
            }
        }

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}
    }
}
