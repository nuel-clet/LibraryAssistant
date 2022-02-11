using LibraryAssistant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAssistant.Data.Models
{
    public interface IBookRepository
    {
        Book GetBook(int Id);
        IEnumerable<Book> GetAllBooks();
        Book Update(Book bookchanges);
        DateTime AddBusinessDays(DateTime now, int days);
        int GetWorkingDays(DateTime start, DateTime end);
    }
}
