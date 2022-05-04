using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.WebAPI.Data;
using MongoDB.WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDB.WebAPI.Repositories
{
    public class BookStoreRepository : IBookStoreRepository
    {
        private readonly IMongoCollection<BookStore> _bookStore;

        public BookStoreRepository(IMongoDbContext mongoDbContext)
        {
            _bookStore = mongoDbContext.GetBookStoreCollection();
        }

        public Task<List<BookStore>> GetListBookStoreAsync()
        {
            var list = _bookStore.Find(new BsonDocument()).ToList();
            return Task.FromResult(list);
        }
    }
}
