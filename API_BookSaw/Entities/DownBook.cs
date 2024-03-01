namespace API_BookSaw.Entities
{
    public class DownBook
    {
        public int id { get; set; }
        public int idClient { get; set; }
        public int idBook { get; set; }
        public System.DateTime createDate { get; set; }
    }
}
