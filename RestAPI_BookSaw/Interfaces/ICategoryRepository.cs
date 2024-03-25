using RestAPI_BookSaw.Entities;

namespace RestAPI_BookSaw.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetSomeCategoryAndBooks();
    }
}
