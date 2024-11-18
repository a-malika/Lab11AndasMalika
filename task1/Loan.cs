using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory11
{
    public class Loan
    {
        public Book Book { get; set; }
        public Reader Reader { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Loan(Book book, Reader reader)
        {
            Book = book;
            Reader = reader;
            LoanDate = DateTime.MinValue;
            ReturnDate = DateTime.MinValue;
        }
        public void IssueLoan()
        {
            LoanDate = DateTime.Now;
        }
        public void CompleteLoan()
        {
            ReturnDate = DateTime.Now;
        } 
    }
}
