using LibraryAssistant.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAssistant.Services
{
    public class BookInventoryRepo:IBookInventoryRepo
    {
        private readonly AppDbContext _context;
        public BookInventoryRepo( AppDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// ADDS A RECORD FOR A BOOK AND BOOK PATRON RELATIONSHIP
        /// </summary>
        /// <param name="bookInventory"></param>
        /// <returns></returns>
        public async Task<BookInventory> AddInventory(BookInventory bookInventory)
        {
           await _context.Book_Inventorys.AddAsync(bookInventory);
           await _context.SaveChangesAsync();
           return bookInventory;
        }
        /// <summary>
        /// RETURNS THE LIST OF RECORDS OF A BOOK 
        /// INCLUDING THE BOOK OBJECT AND BOOKPATRON OBJECT
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<IEnumerable<BookInventory>> GetBookDetails(int Id)
        {
            return await _context.Book_Inventorys
                .Include(f => f.BookPatron)
                .Include(f => f.Book)
                .Where(f => f.BookId == Id).ToListAsync();
        }

        /// <summary>
        /// RETURNS THE RECORD OF THE BORROWED BOOK
        /// THE BOOK ID MAY EXIST MORE THAN ONCE ON THE RECORD, HENCE WE ALSO CHECK THE ISCHECKED IN VALUE
        /// INCLUDING THE BOOK OBJECT AND BOOK PATRON OBJECT
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<BookInventory> GetBorrowedBook(int Id)
        {
            return await _context.Book_Inventorys
                .Include(f => f.BookPatron)
                .Include(f => f.Book)
                .Where(f => f.BookId == Id && !f.IsCheckedIn).FirstOrDefaultAsync();
        }

        //WAS NOT USED
        public async Task<IEnumerable<BookInventory>> GetBooksBorrowedByBookPatron(int bookPatronId)
        {
            return await _context.Book_Inventorys
                .Include(f=>f.BookPatron)
                .Include(f=>f.Book)
                .Where(f => f.BookPatronId == bookPatronId).ToListAsync();
        }

        //WAS NOT USED
        public async Task<IEnumerable<BookInventory>> GetYetToReturnedBooksByBookPatron(int bookPatronId)
        {
            return await _context.Book_Inventorys
                .Include(f => f.BookPatron)
                .Include(f => f.Book)
                .Where(f => f.BookPatronId == bookPatronId && !f.IsCheckedIn).ToListAsync();
        }
    }
}
