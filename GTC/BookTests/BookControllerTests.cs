using FakeItEasy;
using Xunit;
using API.Controllers;
using Services;
using System.Threading.Tasks;
using Domain;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
namespace BookTests
{
    public class BookControllerTests
    {
        [Fact]
        public async Task Get_Book_Name_OK()
        {
            //Arrange
            int count = 1000;
            var fakeBooks = A.CollectionOfDummy<Book>(count).AsEnumerable();
            // var fakePhone = A.Dummy<Phone>();
            var service = A.Fake<IBookService>();
            string name = "Emma";
            A.CallTo(() => service.GetBookByName(name)).Returns(Task.FromResult(fakeBooks));
            var controller = new BookController(service);


            //Act
            var actionResult = await controller.GetBookByName(name);

            //Assert
            Assert.IsType<OkObjectResult>(actionResult);


        }



        [Fact]
        public async Task Get_Books_Author_OK()
        {
            //Arrange
            int count = 1000;
            var fakeBooks = A.CollectionOfDummy<Book>(count).AsEnumerable();
            var service = A.Fake<IBookService>();
            string firstName = "Emma";
            string lastName = "Emma";
            A.CallTo(() => service.GetBookByAuthor(firstName, lastName)).Returns(Task.FromResult(fakeBooks));
            var controller = new BookController(service);


            //Act
            var actionResult = await controller.GetBookByAuthor(firstName, lastName);

            //Assert
            Assert.IsType<OkObjectResult>(actionResult);


        }


        [Fact]
        public async Task Get_Books_isRare_OK()
        {
            //Arrange
            int count = 1000;
            var fakeBooks = A.CollectionOfDummy<Book>(count).AsEnumerable();
            var service = A.Fake<IBookService>();
            A.CallTo(() => service.GetBookIsRare()).Returns(Task.FromResult(fakeBooks));
            var controller = new BookController(service);


            //Act
            var actionResult = await controller.GetBookIsRare();

            //Assert
            Assert.IsType<OkObjectResult>(actionResult);


        }
    }
}
