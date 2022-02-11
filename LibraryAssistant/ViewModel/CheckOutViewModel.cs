using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryAssistant.ViewModel
{
    public class CheckOutViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    
        public long MobileNumber { get; set; }

        [RegularExpression("^\\d{11}$", ErrorMessage = "National ID must be 11 digits")]
        public long NationalId { get; set; }

        [DataType(DataType.Date)]        
        public DateTime Date { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
    }
}
