using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWithMongoDB.Services
{
    public interface IBookService
    {
        //Repository operqations for all books
        List<Book> Get();

        Book Get(string id);


        Book Create(Book book);


        void Update(string id, Book bookIn);

        void Remove(Book bookIn);

    }
}
