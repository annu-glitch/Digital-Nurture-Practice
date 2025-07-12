using Microsoft.AspNetCore.Mvc;

namespace FirstWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static readonly string[] values = new[] { "value1", "value2" };

        // GET: api/Values
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(values);
        }

        // GET: api/Values/5
        [HttpGet("{id}", Name = "GetById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<string> Get(int id)
        {
            if (id < 0 || id >= values.Length)
                return NotFound("Value not found");

            return Ok(values[id]);
        }

        // GET: api/Values/duplicate/5 (duplicate GET method using ActionName)
        [HttpGet("duplicate/{id}")]
        [ActionName("GetDuplicate")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<string> GetDuplicateValue(int id)
        {
            return Ok($"Duplicate method hit. Value ID: {id}");
        }

        // POST: api/Values
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return BadRequest("Value is required");

            return Created("", $"Value '{value}' created successfully");
        }

        // PUT: api/Values/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Put(int id, [FromBody] string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return BadRequest("Value is required");

            return Ok($"Updated value with ID {id} to '{value}'");
        }

        // DELETE: api/Values/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleted value with ID {id}");
        }
    }
}
