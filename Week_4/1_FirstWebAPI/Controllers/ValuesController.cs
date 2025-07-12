using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        static List<string> values = new List<string> { "value1", "value2" };

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(values);
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if (id < 0 || id >= values.Count)
                return NotFound();
            return Ok(values[id]);
        }

        [HttpPost]
        public ActionResult Post([FromBody] string value)
        {
            values.Add(value);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string value)
        {
            if (id < 0 || id >= values.Count)
                return NotFound();

            values[id] = value;
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 0 || id >= values.Count)
                return NotFound();

            values.RemoveAt(id);
            return Ok();
        }
    }
}
