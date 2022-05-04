using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.WebAPI.Models;

namespace MongoDB.WebAPI.Data
{
    public class MongoDbContext : IMongoDbContext
    {
        private readonly IMongoCollection<Comments> _comments;
        private readonly IMongoCollection<BookStore> _bookStore;

        private readonly IMongoCollection<TransactionAnalytics> _transaction;
        public MongoDbContext(IOptions<ConnectionString> options)
        {
            var client = new MongoClient(options.Value.MongoDbConnection);

            // mflix
            var dbMflix = client.GetDatabase(options.Value.MongoDbName.Mflix);
            _comments = dbMflix.GetCollection<Comments>("comments");
            _bookStore = dbMflix.GetCollection<BookStore>("BookStore");
            // analytics
            var dbAnalytic = client.GetDatabase(options.Value.MongoDbName.Analytics);
            _transaction = dbAnalytic.GetCollection<TransactionAnalytics>("transactions");
        }

        #region mflix
        public IMongoCollection<Comments> GetCommentCollection() => _comments;
        public IMongoCollection<BookStore> GetBookStoreCollection() => _bookStore;
        #endregion

        #region Analytics
        public IMongoCollection<TransactionAnalytics> GetTransactionAnalytics() => _transaction;
        #endregion

    }
}
