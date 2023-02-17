using System;

namespace library_demo 
{
    public class Book
    {
        protected string _author = "";
        protected string _title = "";

        public Book() //Constructor #1
        {
            _author = "Anonymous";
            _title = "Unknown";
        }

        public Book(string author, string title) //Constructor #2
        {
            _author = author;
            _title = title;
        }

        public string GetAuthor()
        {
            return _author();
        }

        public void SetAuthor(string author)
        {
            _author = author;
        }

        public string GetTitle()
        {
            return _title();
        }

        public void SetTitle()
        {
            _title = title;
        }


        public string GetBookInfo()
        {
            return $"{_title} by {_author}";
        }

        public string GetPictureBookInfo()
        {
            return $"{_title} by {_author} illustrated by {_illustrator};
        }
    }
}