using LibraryAssistant.Services;
using System;

namespace LibraryAssistant.ViewModel
{
    public class CheckInViewModel
    {
        public BookInventory bookInventory { get; set; }
        public DateTime ActualReturnDate { get; set; }
        public int Penalty { get; set; }
    }
}
