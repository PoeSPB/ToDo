using Microsoft.EntityFrameworkCore;
using ToDo.Domain.DTO;
using ToDo.Domain.Model;
using ToDo.Infrastructure.Data;

namespace ToDo.Infrastructure.Repository
{
    public class AddTodoListRepository
    {
        private readonly Context _context;
        public AddTodoListRepository(Context context) => _context = context;
        public async Task AddTodoAsync(AddTodoDto todoEntryDto)
        {
            List<Employee> employees = await _context.Employees.ToListAsync();

            TodoEntry todoEntry = new();
            todoEntry.Title = todoEntryDto.Title;
            todoEntry.Content = todoEntryDto.Content;
            todoEntry.Employee = employees.FirstOrDefault(e => e.Name == todoEntryDto.Author);
            if(todoEntryDto.ExecutorId != Guid.Empty)
                todoEntry.ExecutorId = todoEntryDto.ExecutorId;
            else 
                todoEntry.ExecutorId = Guid.Empty;
            todoEntry.Priority = todoEntryDto.Priority;
            todoEntry.RunUntill = todoEntryDto.RunUntill;

            _context.TodoEntries.Add(todoEntry);
            await _context.SaveChangesAsync();
        }
    }
}
