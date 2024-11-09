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
            _businessContorller = new BusinessController();
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
        //[Fact]
        //public void GetBusinessByID_notFound()
        //{
        //    //Act
        //    var id = "1";
        //    //var controller = new UsersController();
        //    var result = _businessContorller.Get(id);

        //    //Assert
        //    Assert.IsType<null>(result);
        //}

        //[Fact]//עדין לא יכולה לבדוק אותה מכיון שהרשימה ריקה
        //public void GetBusinessByID_ok()
        //{
        //    //Act
        //    var id = "1";
        //    //var controller = new UsersController();
        //    var result = _businessContorller.Get(id);

        //    //Assert
        //    Assert.IsType<Business>(result);
        //}

        [Fact]
        public void GetByID_ReturnsOk()
        {
            //Arrange
            var id = "123";

            //Act
            var result = _businessContorller.Get(id);

            //Assert
            Assert.IsType<Business>(result);
        }
        [Fact]
        public void GetByID_Returnsnull()
        {
            //Arrange
            var id = "2";

            //Act
            var result = _businessContorller.Get(id);

            //Assert
            Assert.Null(result);
        }

    }
}
