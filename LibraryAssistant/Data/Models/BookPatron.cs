using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAssistant.Data.Models
{
    [Index(nameof(NationalID), IsUnique =true)]
    public class BookPatron
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public long MobileNumber { get; set; }
        
        public long NationalID { get; set; }

        

    }
}
