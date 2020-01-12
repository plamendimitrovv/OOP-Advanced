using System;

namespace _1.Library
{
    class Program
    {
        static void Main()
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);
            Book bookFour = new Book("Once upon a time", 1990, "Some Author");

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);
            Library libraryThree = new Library(bookFour);

        }
    }
}
