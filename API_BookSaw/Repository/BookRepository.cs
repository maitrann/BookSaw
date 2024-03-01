﻿using API_BookSaw.Entities;
using API_BookSaw.Interfaces;
using Dapper;
using System.Data;

namespace API_BookSaw.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookSawEntities _context;
        public BookRepository(BookSawEntities context)
        {
            _context = context;
        }

        public List<Book> GetBooks()
        {
            var query = "SELECT * FROM Book ORDER BY createDate desc";
            using (var connection = _context.CreateConnection())
            {
                var books = connection.Query<Book>(query).ToList();
                return books;
            }
        }
        public List<Book> GetNewBooks()
        {
            var query = "SELECT TOP(4) * FROM Book ORDER BY createDate desc";
            using (var connection = _context.CreateConnection())
            {
                var books = connection.Query<Book>(query).ToList();
                return books;
            }
        }
        public List<Book> GetBooksByCate(int idCate)
        {
            var query = "SELECT * FROM Book WHERE idCate = @idCate ORDER BY createDate desc";
            using (var connection = _context.CreateConnection())
            {
                var books = connection.Query<Book>(query, new {idCate}).ToList();
                return books;
            }
        }
    
    }
}