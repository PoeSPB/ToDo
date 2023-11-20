using Microsoft.AspNetCore.Mvc;
using ToDo.Domain.Model;
using ToDo.Domain.DTO;
using ToDo.Infrastructure.Data;
using ToDo.Infrastructure.Repository;

namespace ToDo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmploeyersController : ControllerBase
    {
        private readonly EmploeyersRepository _emploeyersRepository;
        public EmploeyersController(Context context)
        {
            _emploeyersRepository = new EmploeyersRepository(context);
        }
        // GET: api/Emploeyers
        [HttpGet]
        public async Task<List<EmployeeDto>> Get()
        {
            return await _emploeyersRepository.GetEmploeyersListAsync();
        }

        // GET api/<EmploeyersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmploeyersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmploeyersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmploeyersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
