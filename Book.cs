using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Book
    {
        public string Title; 
        public string Author;
        public int PublishingYear;
        public bool IsLent;

        public Book(string title, string author, int publishingYear, bool isLent)
        {
            Title = title;
            Author = author;
            PublishingYear = publishingYear;
            IsLent = isLent;
        }

        public string GetAuthor()
        {
            return "asdffsda";
        }
    }
}