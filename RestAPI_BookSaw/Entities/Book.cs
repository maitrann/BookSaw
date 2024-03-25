namespace RestAPI_BookSaw.Entities
{
    public class Book
    {
        public int id { get; set; }
        public string linkBook { get; set; }
        public string image { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public bool isActive { get; set; }
        public System.DateTime createDate { get; set; }
        public int idCate { get; set; }
    }
}
