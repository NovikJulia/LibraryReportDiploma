using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryReport.Models
{
    public class Borrow
    {
        public int BorrowId { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
        public int BookId { get; set; }
        public DateTime Date { get; set; }
    }
}