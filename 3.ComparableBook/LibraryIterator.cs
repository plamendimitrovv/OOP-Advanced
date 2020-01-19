﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _3.ComparableBook
{
    public class LibraryIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;
        private int currentIndex;

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }

        public Book Current => this.books[this.currentIndex];

        object IEnumerator.Current => this.Current; 

        public void Dispose() { }

        public bool MoveNext()
        {
            return ++this.currentIndex > this.books.Count;
        }

        public void Reset()
        {
            this.currentIndex = -1; 
        }
    }
}
