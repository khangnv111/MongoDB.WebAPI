using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.WebAPI.Command.BookStore;
using MongoDB.WebAPI.ViewModel;
using System.Threading.Tasks;

namespace MongoDB.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookStoreController : ControllerBase
    {
        public BookStoreController() { }


        [HttpGet("list")]
        public Task<DataReponse> EmployeeGetList([FromServices] GetListBookStoreCommand service)
        {
            return service.ExecuteAsync();
        }
    }
}
