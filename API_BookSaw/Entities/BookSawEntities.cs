﻿using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace API_BookSaw.Entities
{
    public class BookSawEntities
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public BookSawEntities(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlConnection");
        }
        public IDbConnection CreateConnection()
            => new SqlConnection(_connectionString);
    }
}
