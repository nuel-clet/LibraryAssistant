using LibraryAssistant.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAssistant.Services
{
    /// <summary>
    /// THIS TABLE IS RESPOSIBLE FOR HOLDING THE HISTORY OF THE BOOK CHECKING-CHECKOUT TRACK
    /// </summary>
    public class BookInventory 
    {
        public int Id { get; set; }
        public bool IsCheckedIn { get; set; }// this if true means the book has been returned
        public DateTime CheckedOutDate { get; set; }
        public DateTime? CheckedInDate { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public BookPatron BookPatron { get; set; }
        public int BookPatronId { get; set; }
    }
}
