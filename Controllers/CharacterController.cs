using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        // GET: api/<CharacterController>
        [HttpGet]
        public List<Jedi> Get()
        {
            List<Jedi> jedis = new();
            JediFile fileHandler = new(jedis);
            fileHandler.GetAllJedi();
            return jedis;
        }

        // GET api/<CharacterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CharacterController>
        [HttpPost]
        public void Post([FromBody] Jedi value)
        {
            System.Console.WriteLine("helloo?");
            System.Console.WriteLine(value.ToFile());
            List<Jedi> jedis = new();
            JediFile fileHandler = new(jedis);
            fileHandler.AddJediToFile(value);
            // Method intentionally left blank
        }

        // PUT api/<CharacterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CharacterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
