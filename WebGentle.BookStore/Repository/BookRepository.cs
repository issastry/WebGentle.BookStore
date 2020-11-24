using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGentle.BookStore.Models;

namespace WebGentle.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return Datasource();
        }

        public BookModel GetBookById(int id)
        {
            return Datasource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return Datasource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }

        private List<BookModel> Datasource()
        {
            return new List<BookModel>()
            {
                new BookModel() {Id =1, Title = "MVC", Author = "Nitish"},
                new BookModel() {Id =2, Title = "ASP.Net", Author = "Sekhar"},
                new BookModel() {Id =3, Title = "dotnetcore", Author = "Nitish"},
                new BookModel() {Id =4, Title = "C#", Author = "Sekhar"},
                new BookModel() {Id =5, Title = "Javascript", Author = "Richard"}
            };
        }

    }
}
