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
        //private static string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        [HttpGet("[action]")]
        public List<Book> WeatherForecasts()
        {
            var books = db.Books.ToList();
            return (books);
        }

        //[HttpGet("[action]")]
        //public IActionResult Create()
        //{
        //    Console.WriteLine("It's trying to create");
        //    return View();
        //}

        //[HttpPost("[action]")]
        //public IActionResult Create(Book book)
        //{
        //    db.Books.Add(book);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    


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
