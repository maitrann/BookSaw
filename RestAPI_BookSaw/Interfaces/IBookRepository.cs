﻿using RestAPI_BookSaw.Entities;

namespace RestAPI_BookSaw.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetBooks();
        List<Book> GetNewBooks();
        List<Book> GetBooksByCate(int idCate);
        Book GetBooksById(int id);

	}
}
