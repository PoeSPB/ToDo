using Microsoft.AspNetCore.Mvc;
using ToDo.Domain.Model;
using ToDo.Domain.DTO;
using ToDo.Infrastructure.Data;
using ToDo.Infrastructure.Repository;

namespace ToDo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowTodoController : ControllerBase
    {
        private readonly TodoListRepository _toDoListRepository;
        public ShowTodoController(Context context) { 
            _toDoListRepository = new TodoListRepository(context);
        }
        // GET: api/ShowTodo
        [HttpGet]
        public async Task<List<TodoEntryDto>> Get()
        {
            return await _toDoListRepository.GetTodoListAsync();
        }

        // GET api/ShowTodo/{id}
        [HttpGet("{id}")]
        public async Task<TodoEntryDto> Get(Guid id)
        {
            return await _toDoListRepository.GetCurrentTodoListAsync(id);
        }
    }
}
