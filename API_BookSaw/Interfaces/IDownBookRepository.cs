﻿using API_BookSaw.Entities;
using API_BookSaw.ModelsView;

namespace API_BookSaw.Interfaces
{
    public interface IDownBookRepository
    {
        bool DownBookToLib(DownBook model);
        List<DownBookView> GetDownBookViews(int idClient);

    }
}
