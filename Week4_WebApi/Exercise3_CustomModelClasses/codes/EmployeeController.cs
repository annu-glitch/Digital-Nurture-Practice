using FirstWebApiDemo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly List<Employee> _employees;

        public EmployeeController()
        {
            _employees = GetStandardEmployeeList();
        }

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

        // GET api/Employee
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [AllowAnonymous]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(_employees);
        }

        // GET api/Employee/standard
        [HttpGet("standard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Employee> GetStandard()
        {
            return Ok(_employees.First());
        }

        // POST api/Employee
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] Employee emp)
        {
            if (emp == null)
                return BadRequest("Invalid employee data");

            return Created("", emp);
        }
    }
}
