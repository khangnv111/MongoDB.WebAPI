using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.WebAPI.Command.Comment;
using MongoDB.WebAPI.ViewModel;
using System.Threading.Tasks;

namespace MongoDB.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        public CommentController() { }


        [HttpGet("list")]
        public Task<DataReponse> EmployeeGetList([FromServices] GetCommentListCommand service)
        {
            return service.ExecuteAsync();
        }
    }
}
