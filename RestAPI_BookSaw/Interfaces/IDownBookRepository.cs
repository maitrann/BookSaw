using RestAPI_BookSaw.Entities;
using RestAPI_BookSaw.ModelsView;

namespace RestAPI_BookSaw.Interfaces
{
    public interface IDownBookRepository
    {
        bool DownBookToLib(DownBook model);
        List<DownBookView> GetDownBookViews(int idClient);

    }
}
