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
        public Book Create(string bookObject)
        {
            Console.WriteLine(bookObject + "this is the book object");
            //var jsonBook = (bookObject);
            Book newBook = new Book();
            //newBook.Title = bookObject.title;
            //newBook.Author = newAuthor;
            //db.Books.Add(newBook);
            //db.SaveChanges();
            ////var books = db.Books.ToList();
            return (newBook);
        }



        //public class WeatherForecast
        //{
        //    public string DateFormatted { get; set; }
        //    public int TemperatureC { get; set; }
        //    public string Summary { get; set; }

        //    public int TemperatureF
        //    {
        //        get
        //        {
        //            return 32 + (int)(TemperatureC / 0.5556);
        //        }
        //    }
        //}
    }
}
