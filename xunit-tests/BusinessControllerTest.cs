using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wolt_Project;
using Wolt_Project.Controllers;

namespace xunit_tests
{
    public class BusinessControllerTest
    {
        private readonly BusinessController _businessContorller;
        public BusinessControllerTest()
        {
            FakeContext f = new FakeContext();
            _businessContorller = new BusinessController(f);
        }
        [Fact]
        public void GetBusinessList_Ok()
        {
            //Act
            //var controller = new UsersController();
            var result = _businessContorller.Get();

            //Assert
            Assert.IsType<List<Business>>(result);
        }

        [Fact]
        public void GetByID_ReturnsOk()
        {
            //Arrange
            var id = "-1";

            //Act
            var result = _businessContorller.GetById(id);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
        [Fact]
        public void GetByID_Returnsnull()
        {
            //Arrange
            var id = "2";

            //Act
            var result = _businessContorller.GetById(id);

            //Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }
        [Fact]
        public void PostANewBusinessOK()
        {
            var bu = new Business("ccc","rrrr","00000000","-2",true,new List<string>());
            var result = _businessContorller.PostNewBusiness(bu);
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void PostANewBusinessAlreadyExist()
        {
            var bu = new Business("fakeBname", "fakeBadrss", "fakeBphone", "-1", true, new List<string>());
            var result = _businessContorller.PostNewBusiness(bu);
            Assert.IsType<NotFoundObjectResult>(result);
        }

    }
}
