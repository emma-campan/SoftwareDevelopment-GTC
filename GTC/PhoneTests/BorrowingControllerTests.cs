using API.Controllers;
using DataAccessLayerDapper;
using Domain;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;

namespace Tests
{
   
   public class BorrowingControllerTests
    {
        /*
        For the sake of this UnitTesting it is not necesary to have a dependency on the database, We just want to test the
        functionality of the controller
        */

        [Fact]
        public async Task GetBorrowingBySSN()
        {
            //Arrange
            int SSN = 1000123087;
            var fakeBorrowing = A.CollectionOfDummy<Borrowing>(2).AsEnumerable();
            var dataStore = A.Fake<IBorrowingService>();
            A.CallTo(() => dataStore.GetBorrowingBySSN(SSN)).Returns(Task.FromResult(fakeBorrowing));
            var controller = new BorrowingController(dataStore);

            //Act
            var actionResult=  await controller.GetBorrowingBySSN(SSN);

            //Assert
            var result = Assert.IsType<OkObjectResult>(actionResult);
            var returnBorrowings = result.Value as IEnumerable<Borrowing>;
            Assert.Equal(fakeBorrowing, returnBorrowings);

            /*
            Returns a list with the 2 same objects after the execution of the controller - GetBorrowingBySSN method with a status200 OK
            */
        }

        [Fact]
        public void  CreateBorrowing()
        {
            //Arrange

            var fakeBorrowing = A.Dummy<Borrowing>();
            var dataStore = A.Fake<IBorrowingService>();
            A.CallTo(() => dataStore.CreateBorrowing(fakeBorrowing));
            var controller = new BorrowingController(dataStore);

            //Act
            var actionResult =  controller.CreateBorrowing(fakeBorrowing);

            //Assert
            var result = Assert.IsType<OkObjectResult>(actionResult);
            var returnBorrowing = result.Value;
            Assert.Equal(fakeBorrowing, returnBorrowing);

            /*
            Returns the same object after the execution of the controller - CreationBorrowing method with a status200 OK
            */
        }
    }


}
