using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory11
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsAvailable = true;
        }
        public bool MarkAsLoaned()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                return true;
            }
            return false;
        }
        public bool MarkAsAvailable()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                return true;
            }
            return false;
        }
    }
}
