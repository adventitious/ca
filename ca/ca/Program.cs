using System;

using System.Collections.Generic;

namespace ca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> ReadingList = new List<Book>();

            ReadingList.Add(new Book("James Joyce", "Ulysses", Genre.Fiction, new DateTime(1922, 2, 2), 730 ));
            ReadingList.Add(new Book( "B Kernighan and D Ritchie","The C Programming Language", Genre.Fiction, new DateTime(1978, 2, 28), 279 ));
            ReadingList.Add(new Book( "Walter Isaacson","Steve Jobs", Genre.Fiction, new DateTime(2011, 10, 24), 627 ));
            ReadingList.Add(new Book( "JRR Tolkien","The Hobbit", Genre.Fiction, new DateTime(1937, 9, 21), 310 ));
            ReadingList.Add(new Book("James Joyce", "Portrait of the Artist", Genre.Fiction, new DateTime(1916, 12, 29), 299 ));

            DisplayBooks(ReadingList);
            ReadingList.Sort();
            Console.WriteLine();
            DisplayBooks(ReadingList);
            Console.WriteLine();
            DisplayBooksAndAge(ReadingList);
        }


        static void DisplayBooks(List<Book> ReadingList)
        {
            string s1 = "{0,-30}{1,-30}{2,-10}{3,-12}{4,-20}";
            Console.WriteLine(s1, "Author", "Title", "Pages", "Genre", "Publication Date");
            foreach (Book b in ReadingList)
            {
                Console.WriteLine(b.ToString());
            }
        }


        static void DisplayBooksAndAge(List<Book> ReadingList)
        {
            string s1 = "{0,-30}{1,-30}{2,-10}{3,-12}{4,-20}{5,-6}";
            Console.WriteLine(s1, "Author", "Title", "Pages", "Genre", "Publication Date", "Age");
            foreach (Book b in ReadingList)
            {
                Console.WriteLine("{0, -102}{1}", b.ToString(), CalculateAge(b.Published) );
            }
        }


        // adapted from
        // https://stackoverflow.com/questions/4127363/date-difference-in-years-using-c-sharp
        static int CalculateAge(DateTime datetime)
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime d2 = DateTime.Now;

            TimeSpan span = d2.Subtract(datetime);
            int years = (zeroTime + span).Year - 1;

            return years;
        }


        // not used
        static int CalculateAge2(DateTime datetime)
        {
            DateTime d2 = DateTime.Now;
            TimeSpan timespan = d2.Subtract(datetime);
            double y1 = (timespan.Days / 365.25);
            return Convert.ToInt32(Math.Truncate(y1));
        }
    }
}
