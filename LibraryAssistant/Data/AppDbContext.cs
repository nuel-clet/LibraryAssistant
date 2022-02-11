using LibraryAssistant.Data.Models;
using LibraryAssistant.Models;
using LibraryAssistant.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAssistant.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookPatron> Book_Patrons { get; set; }
        public DbSet<BookInventory> Book_Inventorys { get; set; }
    }
}
