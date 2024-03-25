namespace RestAPI_BookSaw.ModelsView
{
    public class DownBookView
    {
        public int id { get; set; }
        public int idClient { get; set; }
        public int idBook { get; set; }
        public string linkBook { get; set; }
        public string image { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string createDate { get; set; }

    }
}
