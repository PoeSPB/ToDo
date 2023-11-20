using Microsoft.EntityFrameworkCore;
using ToDo.Domain.Model;
using ToDo.Domain.DTO;
using ToDo.Infrastructure.Data;

namespace ToDo.Infrastructure.Repository
{
    public class TodoListRepository
    {
        private readonly Context _context;
        public TodoListRepository(Context context) => _context = context;

        public async Task<List<TodoEntryDto>> GetTodoListAsync()
        {
            List<TodoEntry> todos = await _context.TodoEntries.ToListAsync();
            List<Employee> employees = await _context.Employees.ToListAsync();

            string _content = string.Empty;
            string _executor = string.Empty;

            List<TodoEntryDto> dto = new();
            foreach (var todosEntry in todos)
            {
                if (todosEntry.ExecutorId != Guid.Empty) _executor = employees.FirstOrDefault(e => e.Id == todosEntry.ExecutorId).Name;
                else _executor = string.Empty;

                if (todosEntry.Content.Length < 120) _content = todosEntry.Content;
                else _content = todosEntry.Content.Substring(0, 120) + "...";

                dto.Add(new TodoEntryDto()
                {
                    Id = todosEntry.Id,
                    Title = todosEntry.Title,
                    Author = employees.FirstOrDefault(e => e.Id == todosEntry.Employee.Id).Name,
                    Issued = todosEntry.Issued,
                    Executor = _executor,
                    Content = _content
                });
            }
            return dto.OrderByDescending(d => d.Issued).ToList();
        }

        public async Task<TodoEntryDto> GetCurrentTodoListAsync(Guid Id)
        {
            TodoEntry currentTodo = await _context.TodoEntries.SingleOrDefaultAsync(e => e.Id == Id);
            List<Employee> employees = await _context.Employees.ToListAsync();

            string _executor = string.Empty;

            if (currentTodo.ExecutorId != Guid.Empty)
                _executor = employees.FirstOrDefault(e => e.Id == currentTodo.ExecutorId).Name;
            else
                _executor = string.Empty;

            TodoEntryDto dto = new()
            {
                Id = currentTodo.Id,
                Title = currentTodo.Title,
                Author = employees.FirstOrDefault(e => e.Id == currentTodo.Employee.Id).Name,
                Issued = currentTodo.Issued,
                Executor = _executor,
                Content = currentTodo.Content
            };
            return dto;
        }
    }
}