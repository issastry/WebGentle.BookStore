﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle.BookStore.Models;
using WebGentle.BookStore.Repository;

namespace WebGentle.BookStore.Controllers
{
    public class BookController : Controller
    {
      
       private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }

       public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }

        public ViewResult GetBook(int Id)
        {
            var data =  _bookRepository.GetBookById(Id);
            return View(data);
        }

        public ViewResult SearchBooks(string bookName, string authorName)
        {
            var data = _bookRepository.SearchBook(bookName, authorName);
            return View(data);
        }
    }
}
