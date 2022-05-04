using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.WebAPI.Data;
using MongoDB.WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDB.WebAPI.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly IMongoCollection<Comments> _comment;

        public CommentRepository(IMongoDbContext mongoDbContext)
        {
            _comment = mongoDbContext.GetCommentCollection();
        }

        public Task<List<Comments>> GetListCommentAsync()
        {
            var list = _comment.Find(x => true).ToList();
            return Task.FromResult(list);
        }
    }
}
