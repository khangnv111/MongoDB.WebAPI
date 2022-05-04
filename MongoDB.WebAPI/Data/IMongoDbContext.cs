using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.WebAPI.Models;

namespace MongoDB.WebAPI.Data
{
    public interface IMongoDbContext
    {
        IMongoCollection<BookStore> GetBookStoreCollection();
        IMongoCollection<Comments> GetCommentCollection();
        IMongoCollection<TransactionAnalytics> GetTransactionAnalytics();
    }
}