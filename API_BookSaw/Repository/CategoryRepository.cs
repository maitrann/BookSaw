using API_BookSaw.Entities;
using API_BookSaw.Interfaces;
using Dapper;

namespace API_BookSaw.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BookSawEntities _context;
        public CategoryRepository(BookSawEntities context)
        {
            _context = context;
        }
        public List<Category> GetSomeCategoryAndBooks()
        {
            var queryCate = "SELECT TOP(4) * FROM Category ORDER BY NEWID()";
            var queryBookOfCate = "SELECT TOP(8)* FROM Book WHERE idCate = @idCate ORDER BY createDate desc";

            using (var connection = _context.CreateConnection())
            {
                var category = connection.Query<Category>(queryCate).ToList();
                foreach (var item in category)
                {
                    var idCate = item.id;
                    var bookOfCate = connection.Query<Book>(queryBookOfCate, new { idCate }).ToList();
                    item.Books = bookOfCate;
                }
                return category;
            }
        }
    }
}
