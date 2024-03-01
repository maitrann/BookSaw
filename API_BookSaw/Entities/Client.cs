namespace API_BookSaw.Entities
{
    public class Client
    {
        public int id { get; set; }
        public string email { get; set; }
        public bool isActive { get; set; }
        public System.DateTime createDate { get; set; }
    }
}
