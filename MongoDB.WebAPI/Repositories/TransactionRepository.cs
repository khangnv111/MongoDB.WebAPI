using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.WebAPI.Data;
using MongoDB.WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace MongoDB.WebAPI.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly IMongoCollection<TransactionAnalytics> _transaction;

        public TransactionRepository(IMongoDbContext mongoDbContext)
        {
            _transaction = mongoDbContext.GetTransactionAnalytics();
        }

        public Task<List<TransactionAnalytics>> GetListTransactionAsync()
        {
            var list = _transaction.Find(x => true).ToList();
            var lst = list.Take(10).ToList();
            return Task.FromResult(lst);
        }
    }
}
