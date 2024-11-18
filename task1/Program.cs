using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Library library = new Library();
            Librarian librarian = new Librarian(1, "Венция Невольная", "Старший библиотекарь", library);
            Book book1 = new Book("Правила выживания в Джакарте", "Арина Цимеринг, Оксана Багрий", "978-5-00169-984-2");
            Book book2 = new Book("Into the Magic Shop", "James R. Doty", "978-5-17-088431-5");
            Book book3 = new Book("Маленький принц", "Антуан де Сент-Экзюпери", "978-5-17-114560-6");
            Reader reader1 = new Reader(1, "Саша Попов", "sasha3000@mail.ru");
            Reader reader2 = new Reader(2, "Марья Авреева", "MariaVelikaya@gmail.com");
            Reader reader3 = new Reader(3, "Айсулу Аяжанова", "SuLu@gmail.com");
            librarian.AddBook(book1);
            librarian.AddBook(book2);
            librarian.AddBook(book3);
            librarian.RegisterReader(reader1);
            librarian.RegisterReader(reader2);
            librarian.RegisterReader(reader3);
            reader1.BorrowBook(book1, librarian);
            reader1.BorrowBook(book1, librarian);
            reader1.BorrowBook(book2, librarian);
            reader2.ReturnBook(book2, librarian);
            reader1.ReturnBook(book1, librarian);
            reader1.ReturnBook(book2, librarian);
            Book? bookIWant = librarian.FindByTitle("Джакар");
            if (bookIWant != null)
            {
                Console.WriteLine($"I wanted '{bookIWant.Title}'");
            }
        }
    }
}
