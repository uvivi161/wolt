namespace Wolt_Project
{
    public class User
    {
        public string userCode { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string city { get; set; }
        public int numHouse { get; set; }
        public string phone { get; set; }
        public bool status { get; set; }
        public List<string> ordersList { get; set; }
    }
}
