using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wolt_Project;

namespace xunit_tests
{
    public class FakeContext:IDataContext
    {
        public List<User> usersList { get; set; }//11
        public List<Business> businessList { get; set; }//1
        public List<Order> ordersList { get; set; }//111

        public FakeContext()
        {
            usersList = new List<User> { new User("-11", "fakeUfname", "fakeUlname", "fakeUcity", "fakeUadress", -50, "fakeUphone", true, new List<string>()) };
            businessList = new List<Business> { new Business("fakeBname", "fakeBadrss", "fakeBphone", "-1", true, new List<string>())};
            ordersList = new List<Order> { new Order("-111", "fakeOfname", "fakeOlname", new DateTime(), "-1", 100) };
        }
    }
}
