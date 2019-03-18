using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LibraryReport.Models
{
    public class BookContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
    }
   /* public class BookDbInitializer: CreateDatabaseIfNotExists<BookContext>
    {
        protected override void Seed (BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л.Толстой", Price = 120 });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И.Тургенев", Price = 180 });
            db.Books.Add(new Book { Name = "Чайка", Author = "А.Чехов", Price = 230 });
        }
    }
    */
}