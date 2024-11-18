using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory11
{
    public class Librarian
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public Library Library { get; set; }
        public Librarian(int id, string name, string position, Library library)
        {
            Id = id;
            Name = name;
            Position = position;
            Library = library;
        }
        public void AddBook(Book book)
        {
            if (!Library.BookList.Contains(book))
            {
                Library.BookList.Add(book);
                Console.WriteLine($"Book '{book.Title} was added to the library'.");
            }
        }
        public void RemoveBook(Book book)
        {
            if (Library.BookList.Remove(book))
            {
                Console.WriteLine($"Book '{book.Title} was removed from the library'.");
            }
        }
        public void RegisterReader(Reader reader)
        {
            if (!Library.ReaderList.Contains(reader))
            {
                Library.ReaderList.Add(reader);
                Console.WriteLine($"Reader '{reader.Name} was registered to the library'.");
            }
        }
        public void UnregisterReader(Reader reader)
        {
            if (Library.ReaderList.Remove(reader)) {
                Console.WriteLine($"Reader '{reader.Name} was unregistered from the library'.");
            }
        }
        public void OpenLoan(Reader reader, Book book)
        {
            Loan loan = new Loan(book, reader);
            loan.IssueLoan();
            Library.LoanList.Add(loan);
            Console.WriteLine($"Loan was opened: {reader.Name}, {book.Title}, {loan.LoanDate}.");
        }
        public bool CloseLoan(Reader reader, Book book)
        {
            Loan? loan = Library.LoanList.FirstOrDefault(u => u.Reader == reader && u.Book == book && u.ReturnDate == DateTime.MinValue);
            if (loan == null)
            {
                return false;
            }
            loan.CompleteLoan();
            Console.WriteLine($"Loan was closed: {reader.Name}, {book.Title}, {loan.LoanDate}, {loan.ReturnDate}.");
            return true;
        }
        public Book? FindByTitle(string title)
        {
            return Library.BookList.FirstOrDefault(u => u.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
        }
        public Book? FindByAuthor(string author)
        {
            return Library.BookList.FirstOrDefault(u => u.Author.Contains(author, StringComparison.OrdinalIgnoreCase));
        }
    }
}
