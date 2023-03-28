using Microsoft.AspNetCore.Mvc;

namespace MinhaAPICore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        //GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> ObterTodos()
        {
            return new string[] { "value1", "value2" };
        }

        //GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        //POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        //PUT api/values
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }

        //GET api/values
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }

    }
}