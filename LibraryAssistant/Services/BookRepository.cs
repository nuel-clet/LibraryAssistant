using LibraryAssistant.Data;
using LibraryAssistant.Data.Models;
using LibraryAssistant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAssistant.Services
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// RETURNS THE LIST OF BOOKS STORED ON THE SYSTEM
        /// IN OUT CASE : APPLICATION DATABASE INITIALIZER
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        /// <summary>
        /// RETURNS THE BOOK OBJECT THAT MATCHES THE ID
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Book GetBook(int Id)
        {
            return _context.Books.FirstOrDefault(b => b.Id == Id);
        }

        /// <summary>
        /// MAKES CHANGES ON THE BOOK ENTITY
        /// USED TO MANTAIN THE BOOK STATUS
        /// WAS USED IN THE EARLY STAGE OF THE PROJECT
        /// MAY NOT BE USED IN THE FUTURE
        /// </summary>
        /// <param name="bookchanges"></param>
        /// <returns></returns>
        public Book Update(Book bookchanges)
        {
            Book book = _context.Books.FirstOrDefault(b => b.Id == bookchanges.Id);
            if (book != null)
            {
                book.Status = bookchanges.Status;
            }
            _context.SaveChanges();

            return book;
        }

        /// <summary>
        /// 
        /// A UTIITY METHOD THAT IS USED TO ADD WORKING DAYS TO A GIVEN DATE
        /// RETURNS A DATE THAT IS THE SUM OF A GIVEN DATE AND NUMBER OF DAYS
        /// </summary>
        /// <param name="now"></param>
        /// <param name="days"></param>
        /// <returns></returns>
        public DateTime AddBusinessDays(DateTime now, int days)
        {
            var sign = Math.Sign(days);
            var unsigned = Math.Abs(days);
            for (var i = 0; i < unsigned; i++)
            {
                do
                {
                    now = now.AddDays(sign);
                } while (now.DayOfWeek == DayOfWeek.Saturday ||
                now.DayOfWeek == DayOfWeek.Sunday);
            }
            return now;
        }

        /// <summary>
        /// A UTILITY METHOD THAT RETURNS THE NUMBER OF WORKING DAYS BETWEEN TWO DATES
        /// TAKES A DATE AS FIRST PARAMETER AND SECOND PARAMETER
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public int GetWorkingDays(DateTime start, DateTime end)
        {
            var days = 0;
            for (var date = start; date < end; date = date.AddDays(1))
            {
                if (date.DayOfWeek != DayOfWeek.Saturday
                    && date.DayOfWeek != DayOfWeek.Sunday)
                    days++;
            }
            return days;
        }

    }
}
