using System;

namespace _3.ComparableBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2001, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2006, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            libraryTwo.ToString();

            foreach (var book in libraryTwo)
            {
                Console.WriteLine(book);
            }
        }
    }
}
