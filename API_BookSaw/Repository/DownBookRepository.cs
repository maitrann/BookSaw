using API_BookSaw.Entities;
using API_BookSaw.Interfaces;
using API_BookSaw.ModelsView;
using Dapper;
using System.Data;

namespace API_BookSaw.Repository
{
    public class DownBookRepository : IDownBookRepository
    {
        private readonly BookSawEntities _context;
        public DownBookRepository(BookSawEntities context)
        {
            _context = context;
        }
        public void DownBookToLib(DownBook model)
        {
            var query = "INSERT INTO DownBook (idClient,idBook,createDate) VALUES (@idClient, @idBook, @createDate)";
            var parameters = new DynamicParameters();
            parameters.Add("idClient", model.idClient, DbType.String);
            parameters.Add("idBook", model.idBook, DbType.String);
            parameters.Add("createDate", DateTime.Now, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                connection.Execute(query, parameters);
            }
        }

        public List<DownBookView> GetDownBookViews(int idClient)
        {
            var query = "SELECT db.*,b.linkBook,b.image,b.title,b.content FROM DownBook db " +
                "join Book b ON db.idBook =b.id " +
                "where db.idClient=@idClient and b.isActive=1";
            using (var connection = _context.CreateConnection())
            {
                var downbooks = connection.Query<DownBookView>(query, new { idClient });
                return downbooks.ToList();
            }
        }
    }
}
