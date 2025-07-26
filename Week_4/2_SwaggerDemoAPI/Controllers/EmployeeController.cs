using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace SwaggerDemoAPI.Controllers
{
    [Route("api/emp")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // GET /api/emp
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "John", "Jane", "Doe" };
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult Post([FromBody] string employee)
        {
            return Created("", $"Employee '{employee}' added successfully.");
        }

        [HttpGet("all")]
        [ActionName("GetAllEmployees")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            return new string[] { "John", "Jane", "Doe" };
        }

        [HttpGet("one")]
        [ActionName("GetOneEmployee")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<string> GetOne()
        {
            return "John";
        }
    }
}
