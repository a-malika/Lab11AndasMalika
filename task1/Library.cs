using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory11
{
    public class Library
    {
        public List<Book> BookList { get; set; }
        public List<Reader> ReaderList { get; set; }
        public List<Loan> LoanList { get; set; }
        public Library()
        {
            BookList = new List<Book>();
            ReaderList = new List<Reader>();
            LoanList = new List<Loan>();
        }
    }
}
