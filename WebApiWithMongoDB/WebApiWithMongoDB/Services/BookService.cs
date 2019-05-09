using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWithMongoDB.Services
{
    public class BookService : IBookService
    {
        private readonly IMongoCollection<Book> _books;
        public BookService(IConfiguration config)
        {
            var mClient = new MongoClient(config.GetConnectionString("BookStoreCon"));
            var database = mClient.GetDatabase("BookStoreDatabase");
            _books = database.GetCollection<Book>("Books");
        }

        //Repository operqations for all books
        public List<Book> Get()
        {
            return _books.Find(book => true).ToList();
        }

        public Book Get(string id)
        {
            return _books.Find<Book>(book => book.Id==id).FirstOrDefault();
        }

        public Book Create(Book book)
        {
            _books.InsertOne(book);
            return book;
        }

        public void Update(string id,Book bookIn)
        {
            _books.ReplaceOne(x=>x.Id==id,bookIn);
        }

        public void Remove(Book bookIn)
        {
            _books.DeleteOne(x => x.Id == bookIn.Id);
        }




    }
}
