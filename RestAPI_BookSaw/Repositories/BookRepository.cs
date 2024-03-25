using RestAPI_BookSaw.Entities;
using RestAPI_BookSaw.Interfaces;
using Dapper;
using System.Data;

namespace RestAPI_BookSaw.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookSawContext _context;
        public BookRepository(BookSawContext context)
        {
            _context = context;
        }

        public List<Book> GetBooks()
        {
            var query = "SELECT * FROM Book WHERE isActive = 1 ORDER BY NEWID()";
            using (var connection = _context.CreateConnection())
            {
                var books = connection.Query<Book>(query).ToList();
                return books;
            }
        }
        public List<Book> GetNewBooks()
        {
            var query = "SELECT TOP(4) * FROM Book WHERE isActive = 1 ORDER BY createDate desc";
            using (var connection = _context.CreateConnection())
            {
                var books = connection.Query<Book>(query).ToList();
                return books;
            }
        }
        public List<Book> GetBooksByCate(int idCate)
        {
            var query = "SELECT * FROM Book WHERE isActive = 1 AND idCate = @idCate ORDER BY createDate desc";
            using (var connection = _context.CreateConnection())
            {
                var books = connection.Query<Book>(query, new {idCate}).ToList();
                return books;
            }
        }
		public Book GetBooksById(int id)
		{
			var query = "SELECT * FROM Book WHERE isActive = 1 AND id = @id";
			using (var connection = _context.CreateConnection())
			{
				var books = connection.Query<Book>(query, new { id }).FirstOrDefault();
				return books;
			}
		}
	}
}
