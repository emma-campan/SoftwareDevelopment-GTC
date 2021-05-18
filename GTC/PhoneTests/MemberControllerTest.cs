using FakeItEasy;
using Xunit;
using API.Controllers;
using Services;
using System.Threading.Tasks;
using Domain;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Tests
{
    public class MemberControllerTests
    {
        [Fact]
        public async Task Get_Member_Name_OK()
        {
            //Arrange
            int count = 1000;
            var fakeMembers = A.CollectionOfDummy<Member>(count).AsEnumerable();
            // var fakePhone = A.Dummy<Phone>();
            var service = A.Fake<IMemberService>();
            string firstName = "Jim";
            string lastName = "West";
            A.CallTo(() => service.GetMembersByName(firstName, lastName)).Returns(Task.FromResult(fakeMembers));
            var controller = new MemberController(service);


            //Act
            var actionResult = await controller.GetMembersByName(firstName, lastName);

            //Assert
            Assert.IsType<OkObjectResult>(actionResult);


        }



        [Fact]
        public async Task Get_Members_Borrowing_OK()
        {
            //Arrange
            int count = 1000;
            var fakeMembers = A.CollectionOfDummy<Member>(count).AsEnumerable();
            var service = A.Fake<IMemberService>();
            A.CallTo(() => service.GetMembersWithActiveBorrowing()).Returns(Task.FromResult(fakeMembers));
            var controller = new MemberController(service);


            //Act
            var actionResult = await controller.GetMembersWithActiveBorrowing();

            //Assert
            Assert.IsType<OkObjectResult>(actionResult);


        }
    }
}