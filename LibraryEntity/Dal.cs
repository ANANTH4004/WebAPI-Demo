using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEntity
{
    public class Dal
    {
        public LibraryDbEntities context = null;
        public Dal()
        {
            context = new LibraryDbEntities();
        }
        public void AddBook(Book book)
        {
            context.Books.Add(book);  
        }
        public List<Book> GetAllBooks()
        {
            return context.Books.ToList();
        }
        public void EditBook(int id,Book book)
        {
           var booklist = context.Books.ToList();
           var bookfound =  booklist.Find(temp => temp.Book_No == id);
            context.Books.Remove(bookfound);
            context.Books.Add(book);
            context.SaveChanges();
        }
    }
}
