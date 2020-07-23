using ASP.NET_WEB_PRACTISE_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_WEB_PRACTISE_1.Repositry
{
    public class BookRepositry
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> GetBookBySearch(string title , string author)
        {
            return DataSource().Where(x => x.Title.Contains(title) && x.Author.Contains(author)).ToList();

        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id = 1 ,  Title="Book-1", Author="gaurav" },
                new BookModel(){Id = 2 ,  Title="Book-2", Author="gaurav-2" },
                new BookModel(){Id = 3 ,  Title="Book-3", Author="gaurav-3"}
            };
        }
    }

}
