using Microsoft.AspNetCore.Mvc;
using ToDo.Domain.Model;
using ToDo.Domain.DTO;
using ToDo.Infrastructure.Data;
using ToDo.Infrastructure.Repository;
using System.Net;

namespace ToDo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorrectionTodoController : ControllerBase
    {
        private readonly AddTodoListRepository _toDoListRepository;
        public CorrectionTodoController(Context context)
        {
            _toDoListRepository = new AddTodoListRepository(context);
        }

        // POST api/CorrectionTodo
        [HttpPost]
        public async Task<ActionResult<HttpStatusCode>> Post(AddTodoDto todoEntryDto)
        {
            await _toDoListRepository.AddTodoAsync(todoEntryDto);
            return HttpStatusCode.Created;
        }

        // PUT api/<CorrectionTodoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CorrectionTodoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
