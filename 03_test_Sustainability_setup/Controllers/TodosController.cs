using Microsoft.AspNetCore.Mvc;
using _03_test_Sustainability_setup.Data;
using _03_test_Sustainability_setup.Models;

namespace _03_test_Sustainability_setup.Controllers
{
    [ApiController]
    [Route("api/todos")]
    public class TodosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> GetAll()
        {
            return Ok(TodoMockData.Items);
        }
    }
}
