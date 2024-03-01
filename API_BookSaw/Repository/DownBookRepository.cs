using API_BookSaw.Entities;
using API_BookSaw.Interfaces;
using Dapper;
using System.Data;

namespace API_BookSaw.Repository
{
    public class DownBookRepository: IDownBookRepository
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
            parameters.Add("createDate", model.createDate, DbType.String);
            using (var connection = _context.CreateConnection())
            {
                connection.Execute(query, parameters);
            }
        }
    }
}
