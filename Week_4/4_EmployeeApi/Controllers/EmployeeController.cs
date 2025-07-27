using Microsoft.AspNetCore.Mvc;
using EmployeeApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        // 🔸 Hardcoded employee list (in-memory)
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Bob", Department = "HR", Salary = 40000 },
            new Employee { Id = 3, Name = "Charlie", Department = "Finance", Salary = 60000 }
        };

        // 🔁 PUT - Update an existing employee
        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmployee)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);
            if (existingEmployee == null)
                return BadRequest("Invalid employee id");

            existingEmployee.Name = updatedEmployee.Name;
            existingEmployee.Department = updatedEmployee.Department;
            existingEmployee.Salary = updatedEmployee.Salary;

            return Ok(existingEmployee);
        }

        // ➕ POST - Add a new employee
        [HttpPost]
        public ActionResult<Employee> CreateEmployee([FromBody] Employee newEmployee)
        {
            if (newEmployee.Id <= 0)
                return BadRequest("Invalid employee id");

            var exists = employees.Any(e => e.Id == newEmployee.Id);
            if (exists)
                return BadRequest("Employee with given ID already exists");

            employees.Add(newEmployee);
            return CreatedAtAction(nameof(CreateEmployee), new { id = newEmployee.Id }, newEmployee);
        }

        // ❌ DELETE - Remove an employee
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid employee id");

            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return NotFound("Employee not found");

            employees.Remove(employee);
            return Ok($"Employee with ID {id} deleted successfully.");
        }
    }
}
