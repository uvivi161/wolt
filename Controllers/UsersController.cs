using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Wolt_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static List<User> usersList= new List<User>() { };

        //מחזיר רשימת לקוחות
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return usersList;
        }

        //שליפת לקוח לפי שם פרטי ושם משפחה
        // GET api/<UsersController>/5
        [HttpGet("id")]
        public User Get(string fName,string lName)
        {
            for (int i = 0; i < usersList.Count; i++)
            {
                if (usersList[i].firstName == fName && usersList[i].lastName == lName)
                    return usersList[i];
            }
            return null;
        }
        ////מציאת כמות הזמנות לחנות מסוימת
        //[HttpGet("{businessCode}")]
        //public string Get(string buisnessCode)
        //{
        //    int count = 0;
        //    for (int i = 0; i < usersList.Count; i++)
        //    {
        //        for (int j = 0; j < usersList[i].ordersList.Count; j++)
        //        {
        //            if (usersList[i].ordersList[i].businesCode == businesCode)
        //                count++;
        //        }
        //    }
        //    return $"{count}";

        //הוספת לקוח
        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] User us)
        {
            usersList.Add(new User { firstName = us.firstName, lastName = us.lastName, city = us.city, numHouse = us.numHouse, status = true, userCode = us.userCode, phone = us.phone });
        }

        //עדכון פרטי לקוח מסוים לפי קוד לקוח
        //מאפשר לעדכן שם משפחהת כתובת וטלפון
        // PUT api/<UsersController>/5
        [HttpPut("id")]
        public void Put(string id, [FromBody] User us)
        {
            for (int i = 0; i < usersList.Count; i++)
            {
                if (usersList[i].userCode == id)
                {
                    usersList[i].lastName = us.lastName;
                    usersList[i].city = us.city;
                    usersList[i].numHouse = us.numHouse;
                    usersList[i].phone = us.phone;
                    break;
                }
            }
        }

        //עדכון סטטוס לקוח מפעיל ללא פעיל
        [HttpPut("user/id")]
        public void Put(string id, bool status)
        {
            for (int i = 0; i < usersList.Count; i++)
            {
                if (usersList[i].userCode == id)
                {
                    usersList[i].status = status;
                    break;
                }
            }
        }
    }
}
