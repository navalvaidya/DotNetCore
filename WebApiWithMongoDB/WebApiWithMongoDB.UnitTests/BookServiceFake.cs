using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApiWithMongoDB.Services;

namespace WebApiWithMongoDB.UnitTests
{
    class BookServiceFake : IBookService
    {
        private readonly List<Book> _books;

        public BookServiceFake()
        {
            _books = new List<Book>();
            for(int i = 0; i < 10; i++)
            {
                _books.Add(new Book
                {
                    Id = Guid.NewGuid().ToString(),
                    Author = "Auth" + i.ToString(),
                    Bookname = "Bookname" + i.ToString(),
                    Category = "Category" + i.ToString(),
                    Price =  100+i
                });
            }
        }

        
        public List<Book> Get()
        {
            return _books;
        }

        public Book Get(string id)
        {
            return _books.Where(x => x.Id == id).FirstOrDefault();
        }

        public Book Create(Book book)
        {
            _books.Add(book);
            return book;
        }

        public void Update(string id, Book bookIn)
        {
            throw new NotImplementedException();
        }

        public void Remove(Book bookIn)
        {
            _books.Remove(bookIn);
        }
    }
}
