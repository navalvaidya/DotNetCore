using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWithMongoDB.Services
{
    public class BookService
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
    }
}
