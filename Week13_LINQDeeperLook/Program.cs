using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*  So far this semester we have been using LINQ to Objects
 *  Used to access in-memory collections of data 
 *  Quick review
 *   
*/

namespace Week13_LINQDeeperLook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>
           {
                new Book {
                    Title = "The Fellowship of the Ring",
                    Author = "J.R.R Tolkein",
                    Genre = "Fantasy",
                    PublicationYear = 1965
                },
                new Book {
                    Title = "Name of the Wind",
                    Author = "Patrick Rothfuss",
                    Genre = "Fantasy",
                    PublicationYear = 2007
                },
                new Book { Title = "Wise Man Fears",
                    Author = "Patrick Rothfuss",
                    Genre = "Fantasy",
                    PublicationYear = 2011
                },
                new Book {
                    Title = "The Black Echo",
                    Author = "Michael Connelly",
                    Genre = "Mystery",
                    PublicationYear = 1992
                },
                new Book {
                    Title = "Leviathan Awakes",
                    Author = "J.A. Corey",
                    Genre = "Sci-Fi",
                    PublicationYear = 2007
                },
                new Book {
                    Title = "A Walk Among the Tombstones",
                    Author = "Lawrence Block",
                    Genre = "Mystery",
                    PublicationYear = 1992
                },
                new Book {
                    Title = "The Day of Triffids",
                    Author = "John Wyndham",
                    Genre = "Science Fiction",
                    PublicationYear = 1951
                    },
           };

            // Query Syntax
            // IEnumerable<Book> resultAuthorQuerySyntax =
            //  from book in bookList
            //  where book.Author == "Patrick Rothfuss"
            //  select book;

            //foreach (var book in resultAuthorQuerySyntax)
            //{
            //    Console.WriteLine(book);
            //}

            var resultAuthorQuerySyntax2 =
                from bookQuery in bookList
                where bookQuery.Genre == "Sci-Fi"
                select new { bookQuery.Title, bookQuery.Author };

            //foreach(var book2 in resultAuthorQuerySyntax2)
            //{
            //    Console.WriteLine($"{book2.Title}, {book2.Author} ");
            //}


            // Method Syntax 
            var resultsAuthorMethodSyntax =
                bookList.Where(testBook => testBook.Author == "Patrick Rothfuss");


            //bool AMethod(Book book)
            //{
            //    return book.Author == "Patrick Rothfuss";
            //}


            var resultsAuthorMethodSyntax2 =
                 bookList.Where(testBook => testBook.Author == "Patrick Rothfuss")
                 .OrderByDescending(x => x.PublicationYear);

            foreach (var book3 in resultsAuthorMethodSyntax2)
            {
                Console.WriteLine($"{book3.Title}, {book3.PublicationYear} {book3.Author}");
            }


            Console.ReadKey();
        }
    }
}
