using FirstWebApiDemo.CustomFilters;
using FirstWebApiDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(CustomAuthFilter))] // Apply custom authorization filter
    public class EmployeeController : ControllerBase
    {
        private readonly List<Employee> _employees;

        public EmployeeController()
        {
            _employees = GetStandardEmployeeList();
        }

        /// <summary>
        /// Generates a standard list of employees.
        /// </summary>
        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "John",
                    Salary = 50000,
                    Permanent = true,
                    DateOfBirth = new DateTime(1990, 5, 24),
                    Department = new Department { Id = 1, Name = "IT" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "SQL" }
                    }
                },
                new Employee
                {
                    Id = 2,
                    Name = "Jane",
                    Salary = 60000,
                    Permanent = false,
                    DateOfBirth = new DateTime(1992, 11, 15),
                    Department = new Department { Id = 2, Name = "HR" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 3, Name = "Communication" }
                    }
                }
            };
        }

        /// <summary>
        /// Returns the list of all employees.
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [AllowAnonymous] // Allows unauthenticated access
        public ActionResult<List<Employee>> Get()
        {
            return Ok(_employees);
        }

        /// <summary>
        /// Returns the first employee as a standard example.
        /// </summary>
        [HttpGet("standard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Employee> GetStandard()
        {
            // Trigger exception intentionally for testing
            throw new Exception("Demo: Something went wrong while fetching standard employee.");
        }

        /// <summary>
        /// Adds a new employee. Uses FromBody for input.
        /// </summary>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] Employee emp)
        {
            if (emp == null)
                return BadRequest("Invalid employee data");

            // Normally you'd save to DB here
            return Created("", emp);
        }
    }
}
