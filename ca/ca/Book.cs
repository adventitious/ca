using System;
using System.Collections.Generic;
using System.Text;

namespace ca
{

    enum Genre
    {
        Fiction,
        Biography,
        Computing,
        Literature,
    }


    class Book : IComparable<Book>
    {
        #region properties

        public string Title { get; private set; }
        public string Author { get; private set; }
        public DateTime Published { get; private set; }
        public int Pages { get; private set; }
        public Genre Genre { get; private set; }

        #endregion properties

        #region constructors

        public Book(String author, string title, Genre genre, DateTime published, int pages)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Published = published;
            Pages = pages;
        }

        public Book(String author, string title, Genre genre, DateTime published )
            :this ( author, title, genre, published, 0 )
        {

        }

        public Book(String author, string title)
            :this(author, title, Genre.Fiction, DateTime.Now )
        {

        }


        #endregion constructors


        public override string ToString()
        {
            string s1 = "{0,-30}{1,-30}{2,-10}{3,-12}{4,-20}";
            return string.Format(s1, Author, Title, Pages, Genre, Published.ToShortDateString() );
        }

        public int CompareTo(Book that)
        {
            if( this.Author == that.Author )
            {
                bool b1 = string.Compare(this.Title, that.Title) < 0;
                if (b1)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                bool b1 = string.Compare(this.Author, that.Author) < 0;
                if (b1)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
