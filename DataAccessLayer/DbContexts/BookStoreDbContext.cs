using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer.DbContexts
{
    public class BookStoreDbContext:DbContext
    {
        private IConfiguration _configuration;
        public BookStoreDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connstr = _configuration.GetConnectionString("ConnString");
            base.OnConfiguring
                (
                optionsBuilder.UseSqlServer(connstr)
                );
        }

    }
}
