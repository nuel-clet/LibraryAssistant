﻿using LibraryAssistant.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAssistant.Services
{
    public interface IBookPatronRepo
    {
        BookPatron AddBookPatron(BookPatron bookPatron);
    }
}
