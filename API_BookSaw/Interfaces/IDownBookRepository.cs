using API_BookSaw.Entities;

namespace API_BookSaw.Interfaces
{
    public interface IDownBookRepository
    {
        void DownBookToLib(DownBook model);
    }
}
