using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex=-1;

            public LibraryIterator(List<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }

            public bool MoveNext()
            {
                currentIndex++;
                return this.currentIndex < this.books.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }

            public Book Current => this.books[currentIndex];
            object IEnumerator.Current => this.Current;
            public void Dispose() { }
        }

        private List<Book> books;

        public Library(params Book[] books)
        {
            Array.Sort(books,new BookComparator());
            this.books = books.ToList();
        }
    }
}