namespace API_BookSaw.Entities
{
    public class Category
    {
        public Category()
        {
            Books = new List<Book>();
        }
        public int id { get; set; }
        public string title { get; set; }
        public bool isActive { get; set; }
        public List<Book> Books { get; set; }
    }
}
