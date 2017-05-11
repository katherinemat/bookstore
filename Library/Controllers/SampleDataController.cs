using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Library.Models;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private LibraryDbContext db = new LibraryDbContext();

        [HttpGet("[action]")]
        public List<Book> WeatherForecasts()
        {
            var books = db.Books.ToList();
            return (books);
        }

        [HttpPost("[action]")]
        public Book Create(string newAuthor, string newTitle)
        {
            Book newBook = new Book();
            newBook.Title = newTitle;
            newBook.Author = newAuthor;
            db.Books.Add(newBook);
            db.SaveChanges();
            return (newBook);
        }
    }
}
