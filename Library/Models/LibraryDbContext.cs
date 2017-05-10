using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Library.Models;

namespace Library.Models
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public LibraryDbContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Library;integrated security=True");
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}