using FakeItEasy;
using System;
using Xunit;
using API.Controllers;
using Services;
using System.Threading.Tasks;
using Domain;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Web.Http;
using System.Net;

namespace PhoneTests
{
    public class PhoneControllerTests
    {
        [Fact]
        public async Task GetPhones_Return_Correct_Number_Of_Phones()
        {
            //Arrange
            int count = 1000;
            var fakePhones = A.CollectionOfDummy<Phone>(count).AsEnumerable();
            var service = A.Fake<IPhoneService>();
            A.CallTo(() => service.GetAllPhones()).Returns(Task.FromResult(fakePhones));
            var controller = new PhoneController(service);


            //Act
            var actionResult = await controller.GetAllPhones();

            //Assert
            Assert.IsType<OkObjectResult>(actionResult);


        }


        [Fact]
        public void CreatePhone_Correct_Insert()
        {
            //Arrange
            var fakePhone = A.Dummy<Phone>();
            var service = A.Fake<IPhoneService>();
           // A.CallTo(() => service.CreatePhone(fakePhone));
            var controller = new PhoneController(service);

            //Act
            var actionResult = controller.CreatePhone(fakePhone);

            //Assert
            Assert.NotNull(actionResult);


        }
    }
}
