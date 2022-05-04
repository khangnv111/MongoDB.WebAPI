using MongoDB.Bson;
using MongoDB.WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDB.WebAPI.Repositories
{
    public interface ICommentRepository
    {
        Task<List<Comments>> GetListCommentAsync();
    }
}