using EFC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC.Data
{

    public partial class BookContext : DbContext
    {


        public BookContext()
        {
        }

        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }


        public virtual DbSet<Book> Books { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=H9B1T72-SHEL;Database=training;Trusted_Connection=True;MultipleActiveResultSets=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Book>()
            //  .Property(b => b.price)
            //  .IsRequired() //Required
            //  .HasColumnName("BKPrice")
            //  .HasDefaultValue(200);

        }
       
        }
    }



    

