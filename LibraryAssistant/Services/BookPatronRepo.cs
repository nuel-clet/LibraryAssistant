using LibraryAssistant.Data;
using LibraryAssistant.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAssistant.Services
{
    public class BookPatronRepo : IBookPatronRepo
    {
        private readonly AppDbContext _context;

        public BookPatronRepo(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// ADDS THE BOOKPATRON RECORD
        /// </summary>
        /// <param name="bookPatron"></param>
        /// <returns></returns>
        public BookPatron AddBookPatron(BookPatron bookPatron)
        {
            _context.Book_Patrons.Add(bookPatron);
            _context.SaveChanges();
            return bookPatron;
        }
    }
}
