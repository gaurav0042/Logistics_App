using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_WEB_PRACTISE_1.Models;
using ASP.NET_WEB_PRACTISE_1.Repositry;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_WEB_PRACTISE_1.Controllers
{
    public class BookController : Controller
    {
        public readonly BookRepositry bookRepositry = null;

        public BookController()
        {
            bookRepositry = new BookRepositry();
        }
        public List<BookModel> getAllbooks()
        {
            return bookRepositry.GetAllBooks();
        }

        public BookModel GetBookById(int id)
        {
            return bookRepositry.GetBookById(id);
        }

        public List<BookModel> getbooksearch(string title, string author)
        {
            return bookRepositry.GetBookBySearch(title, author);
        }

    }
}