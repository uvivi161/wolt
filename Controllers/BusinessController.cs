using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Wolt_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : ControllerBase
    {
        private static List<Business> businessList= new List<Business>() { };

        //מחזירה רשימת עסקים
        // GET: api/<BusinessController>
        [HttpGet]
        public IEnumerable<Business> Get()
        {
            return businessList;
        }

        //שליפת עסק לפי קוד עסק
        // GET api/<BusinessController>/5
        [HttpGet("businessCode")]
        public Business Get(string id)
        {
            for (int i = 0; i < businessList.Count; i++)
            {
                if (businessList[i].businessCode == id)
                    return businessList[i];
            }
            return null;
        }

        //הוספת עסק
        // POST api/<BusinessController>
        [HttpPost]
        public void Post([FromBody] Business bu)
        {
            businessList.Add(bu);
        }

        //עדכון פרטי עסק
        // PUT api/<BusinessController>/5
        [HttpPut("businessCode")]
        public void Put(string id, [FromBody] Business bu)
        {
            for (int i = 0; i < businessList.Count; i++)
            {
                if (businessList[i].businessCode == id)
                {
                    businessList[i].adress = bu.adress;
                    businessList[i].businessName = bu.businessName;
                    businessList[i].businessPhone = bu.businessPhone;
                }
            }
        }

        //עדכון סטטוס לקוח
        [HttpPut("status/businessCode")]
        public void Put(string id, bool status)
        {
            for (int i = 0; i < businessList.Count; i++)
            {
                if (businessList[i].businessCode == id)
                {
                    businessList[i].status = status;
                    break;
                }
            }
        }
    }
}
