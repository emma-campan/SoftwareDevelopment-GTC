using FakeItEasy;
using System;
using Xunit;
using API.Controllers;
using Services;
using System.Threading.Tasks;
using Domain;
using System.Linq;

namespace PhoneTests
{
    public class PhoneControllerTests
    {
        [Fact]
        public void GetPhones_Return_Correct_Number_Of_Phones()
        {
            //Arrange
            int count = 1000;
            var fakePhones = A.CollectionOfDummy<Phone>(count).AsEnumerable();
            var service = A.Fake<IPhoneService>();
            A.CallTo(() => service.GetAllPhones()).Returns(Task.FromResult(fakePhones));
            var controller = new PhoneController(service);


            //Act


            //Assert
        }
    }
}
