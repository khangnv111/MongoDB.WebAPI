using MongoDB.WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDB.WebAPI.Repositories
{
    public interface ITransactionRepository
    {
        Task<List<TransactionAnalytics>> GetListTransactionAsync();
    }
}