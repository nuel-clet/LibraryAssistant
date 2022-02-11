using LibraryAssistant.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAssistant.Services
{
    public interface IBookInventoryRepo
    {
        Task<BookInventory> AddInventory(BookInventory bookInventory);
        Task<IEnumerable<BookInventory>> GetBookDetails(int Id);
        Task<BookInventory> GetBorrowedBook(int Id);
        Task<IEnumerable<BookInventory>> GetBooksBorrowedByBookPatron(int bookPatronId);
        Task<IEnumerable<BookInventory>> GetYetToReturnedBooksByBookPatron(int bookPatronId);
    }
}
