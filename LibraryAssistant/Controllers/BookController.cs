using LibraryAssistant.Data.Models;
using LibraryAssistant.Services;
using LibraryAssistant.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace LibraryAssistant.Controllers
{

    public class BookController : Controller
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookRepository _book;
        private readonly IBookInventoryRepo _bookInventory;
        private readonly IBookPatronRepo _bookPatron;

        public BookController(ILogger<BookController> logger, IBookRepository book,
                                IBookInventoryRepo bookInventory, IBookPatronRepo bookPatron)
        {
            //  _logger = logger;
            _book = book;
            _bookInventory = bookInventory;
            _bookPatron = bookPatron;
            _logger = logger;
        }

        public IActionResult Index()
        {            
            try
            {
                List<Book> book = _book.GetAllBooks().ToList();
                return View(book);
            }
            catch (NullReferenceException ex)
            {
                _logger.LogError(ex, "Null Reference from index");
            }

            return Redirect("Error/Error");
        }

        /// <summary>
        /// RETURNS A VIEW, WITH DATA TO POPULATE THE VIEW
        /// USES THE ID TO GET THE BOOK THAT WAS SELECTED
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IActionResult CheckIn(int Id)
        {
            try
            {
                BookInventory bookInventory = _bookInventory.GetBorrowedBook(Id).Result;

                var requiredDate = (DateTime)bookInventory.CheckedInDate;
               
                var model = new CheckInViewModel
                {
                    ActualReturnDate = DateTime.Today.Date,
                    bookInventory = _bookInventory.GetBorrowedBook(Id).Result,
                    Penalty = _book.GetWorkingDays(requiredDate.Date, DateTime.Today.Date)
                };
                bookInventory.IsCheckedIn = true;
                bookInventory.CheckedInDate = DateTime.Today.Date;
                Book book = _book.GetBook(Id);
                book.Status = true;
                _book.Update(book);

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception found in Check In page");
            }
            return RedirectToAction("Error", "Error");

        }

        /// <summary>
        /// RETURNS A VIEW WITH DATA TO POPULATE IT
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CheckOut(int Id)
        {
            try
            {
                Book book = _book.GetBook(Id);
                var model = new CheckOutViewModel()
                {
                    Id = book.Id,
                    Date = DateTime.Today.Date,
                    ReturnDate = _book.AddBusinessDays(DateTime.Today, 15)

                };
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception found in Check Out HttpGet");
            }
            return RedirectToAction("Error", "Error");

        }

        /// <summary>
        /// CREATES A BOOK-PATRON OBJECT AND STROES DATA
        /// STORES THE BOOK AND BOOK-PATRON IN THE BOOK INVENTORY
        /// USES A RESPONSE.REDIRECT TO CAUSE A RELOAD OF THE INDEX PAGE
        /// </summary>
        /// <param name="model"></param>
        [HttpPost]
        public IActionResult CheckOut(CheckOutViewModel model)
        {
            try
            {
                Book book = _book.GetBook(model.Id);
                if (ModelState.IsValid)
                {
                    
                    if (book.Status == true)
                    {
                        book.Status = false;

                        BookPatron bookPatron = new BookPatron
                        {
                            Name = model.Name,
                            NationalID = model.NationalId,
                            MobileNumber = model.MobileNumber
                        };

                        BookInventory bookInventory = new BookInventory
                        {
                            IsCheckedIn = false,
                            CheckedOutDate = model.Date,
                            CheckedInDate = model.ReturnDate,
                            Book = _book.GetBook(model.Id),
                            BookId = model.Id,
                            BookPatron = bookPatron
                        };
                        _bookInventory.AddInventory(bookInventory);
                    } 
                    
                }                
                return RedirectToAction("detail", new { id = book.Id });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception found in Check Out HttpPost");
                return View("Error/Error");
            }
           
        }

        [HttpGet]
        public IActionResult Detail(int Id)
        {
            try
            {
                Book book = _book.GetBook(Id);
                return View(book);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception found in Detail page");
                return View("Error/Error");
            }

        }


        /// <summary>
        /// RETURNS BOOK DETAILS AS JSON (IF THERE IS NO INVENTORY, USED AT THE EARLY STAGE OF THE PROJECT)
        /// OR
        /// RETURNS BOOK INVENTORY RECORDS AS JSON
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Details(int Id)
        {
            try
            {
                Book book = _book.GetBook(Id);
                List<BookInventory> bookInventory = (List<BookInventory>)_bookInventory.GetBookDetails(Id).Result;
                if (bookInventory.Any())
                {
                    return Json(new { BookInventory = bookInventory });
                }

                return Json(new { Book = book });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Exception found in Check In page");                
                var message = "An Error Occured";
                Object error = message;
                return Json(error);
            }
            
        }
          

    }
}
