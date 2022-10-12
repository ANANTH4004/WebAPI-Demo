using LibraryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class BookController : ApiController
    {
        // GET api/<controller>
        Dal help = null;
        public BookController()
        {
            help = new Dal();
        }
        public List<MBook> Get()
        {
            List<MBook> books = new List<MBook>();
            var booklist = help.GetAllBooks();
            foreach (var item in booklist)
            {
                books.Add(new MBook { Book_No = item.Book_No, Book_Name = item.Book_Name, Author = item.Author, Cost = item.Cost, Category = item.Category, Availability =item.Availability });
            }
            return books;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [Route("booklist")]
        public void Post([FromBody] MBook value)
        {
            Book book = new Book();
            book.Cost = value.Cost;
            book.Author = value.Author;
            book.Availability = value.Availability; 
            book.Book_Name = value.Book_Name;
            book.Book_No = value.Book_No;
            book.Category = value.Category;
            help.AddBook(book);
            help.context.SaveChanges();

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] MBook value)
        {
            Book book = new Book();
            book.Cost = value.Cost;
            book.Author = value.Author;
            book.Availability = value.Availability;
            book.Book_Name = value.Book_Name;
            book.Book_No = value.Book_No;
            book.Category = value.Category;
            help.EditBook(id, book);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}