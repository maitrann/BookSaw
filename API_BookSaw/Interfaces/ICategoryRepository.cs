using API_BookSaw.Entities;

namespace API_BookSaw.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetSomeCategoryAndBooks();
    }
}
