using LibraryAssistant.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAssistant.Data.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ISBN { get; set; }

        [Required]
        public string Title { get; set; }
       
        public int PublishYear { get; set; }

        public int CoverPrice { get; set; }

        [Required]
        public bool Status { get; set; }//if true that means book is available

    }
}
