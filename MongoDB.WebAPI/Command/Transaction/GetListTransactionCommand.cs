using MongoDB.WebAPI.Repositories;
using MongoDB.WebAPI.ViewModel;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDB.WebAPI.Command.Transaction
{
    public class GetListTransactionCommand
    {
        private readonly ITransactionRepository _transaction;
        public GetListTransactionCommand(ITransactionRepository transaction)
        {
            _transaction = transaction;
        }

        public async Task<DataReponse> ExecuteAsync()
        {
            var listComment = await _transaction.GetListTransactionAsync().ConfigureAwait(false);

            return new DataReponse(listComment);
        }
    }
}
