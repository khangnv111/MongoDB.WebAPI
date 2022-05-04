using MongoDB.WebAPI.Repositories;
using MongoDB.WebAPI.ViewModel;
using System.Threading.Tasks;

namespace MongoDB.WebAPI.Command.Comment
{
    public class GetCommentListCommand
    {
        private readonly ICommentRepository _commentRepository;
        public GetCommentListCommand(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<DataReponse> ExecuteAsync()
        {
            var listComment = await _commentRepository.GetListCommentAsync();

            return new DataReponse(listComment);
        }
    }
}
