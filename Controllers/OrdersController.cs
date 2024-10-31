using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Wolt_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private static List<Order> ordersList= new List<Order>() { };
        
        //שליפת רשימת הזמנות 
        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return ordersList;
        }

        //שליפת הזמנה לפי קוד הזמנה
        // GET api/<OrdersController>/5
        [HttpGet("orderCode")]
        public Order Get(string id)
        {
            for (int i = 0; i < ordersList.Count; i++)
            {
                if (ordersList[i].orderCode == id)
                    return ordersList[i];
            }
            return null;
        }

        //הוספת הזמנה
        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] Order or)
        {
            ordersList.Add(or);
        }

        //עדכון פרטי הזמנה
        // PUT api/<OrdersController>/5
        [HttpPut("orderCode")]
        public void Put(string id, [FromBody] Order or)
        {
            for (int i = 0; i < ordersList.Count; i++)
            {
                if (ordersList[i].orderCode == id)
                {
                    ordersList[i].lastName = or.lastName;
                    ordersList[i].firstName = or.firstName;
                    ordersList[i].businesCode = or.businesCode;
                    ordersList[i].orderDate = or.orderDate;
                }
            }
        }

        //מוחק את ההזמנה
        // DELETE api/<OrdersController>/5
        [HttpDelete("orderCode")]
        public void Delete(string id)
        {
            for (int i = 0; i < ordersList.Count; i++)
            {
                if (ordersList[i].orderCode == id)
                {
                    ordersList.Remove(ordersList[i]);
                    break;
                }
            }
        }
    }
}
