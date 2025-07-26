using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "Admin")] // ✅ Only 'Admin' role can access
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("✅ You are authorized to access Employee data!");
        }
    }
}
