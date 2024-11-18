using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory11
{
    public class Reader
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Reader(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
        public bool BorrowBook(Book book, Librarian librarian)
        {
            if (book == null || librarian == null)
            {
                Console.WriteLine($"Book cannot be loaned.");
                return false;
            }
            if (book.MarkAsLoaned())
            {
                librarian.OpenLoan(this, book);
                Console.WriteLine($"{this.Name} loaned the book '{book.Title}'.");
                return true;
            }
            Console.WriteLine($"Book cannot be loaned.");
            return false;
        }
        public bool ReturnBook(Book book, Librarian librarian)
        {
            if (book == null || librarian == null)
            {
                Console.WriteLine($"Book cannot be returned.");
                return false;
            }
            if (book.MarkAsAvailable())
            {
                if (librarian.CloseLoan(this, book))
                {
                    Console.WriteLine($"{this.Name} returned the book '{book.Title}'.");
                    return true;
                }
                book.MarkAsLoaned();
            }
            Console.WriteLine($"Book cannot be returned.");
            return false;
        }
    }
}
