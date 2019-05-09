using System;
using System.Collections.Generic;
using WebApiWithMongoDB.Controllers;
using WebApiWithMongoDB.Services;
using Xunit;

namespace WebApiWithMongoDB.UnitTests
{
    public class BooKControllerTests
    {
        BooksController _bController;
        IBookService _service;


        public BooKControllerTests()
        {
            _service = new BookServiceFake();
            _bController = new BooksController(_service);
        }

        [Fact]
        public void BooksControllerGetPOS1()
        {
            //Act
            var result = _bController.Get();

            var books = result.Value;

            //Assert
            Assert.IsType<List<Book>>(books);
            //Check if method gets all the books from the store
            Assert.Matches(books.Count.ToString(),"9");
            //Test if all books have id in GUID format
            

        }

        [Fact]
        public void BooksControllerGetByIdNEG01()
        {
            var newGUID = Guid.NewGuid().ToString();
            var result = _bController.Get(newGUID);
            var strRsultType = result.GetType();
        }

    }
}
