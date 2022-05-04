using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.WebAPI.Command.Transaction;
using MongoDB.WebAPI.ViewModel;
using System.Threading.Tasks;

namespace MongoDB.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        public TransactionController() { }

        [HttpGet("list")]
        public Task<DataReponse> EmployeeGetList([FromServices] GetListTransactionCommand service)
        {
            return service.ExecuteAsync();
        }
    }
}
