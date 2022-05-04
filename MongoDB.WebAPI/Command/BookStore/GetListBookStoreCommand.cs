using MongoDB.WebAPI.Repositories;
using MongoDB.WebAPI.ViewModel;
using System.Threading.Tasks;

namespace MongoDB.WebAPI.Command.BookStore
{
    public class GetListBookStoreCommand
    {
        private readonly IBookStoreRepository _bookStoreRepository;
        public GetListBookStoreCommand(IBookStoreRepository bookStoreRepository)
        {
            _bookStoreRepository = bookStoreRepository;
        }

        public async Task<DataReponse> ExecuteAsync()
        {
            var listComment = await _bookStoreRepository.GetListBookStoreAsync();

            return new DataReponse(listComment);
        }
    }
}
