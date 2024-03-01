using API_BookSaw.Entities;

namespace API_BookSaw.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetBooks();
        List<Book> GetNewBooks();
        List<Book> GetBooksByCate(int idCate);
    }
}
