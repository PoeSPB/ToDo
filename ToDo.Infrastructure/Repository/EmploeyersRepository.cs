using Microsoft.EntityFrameworkCore;
using ToDo.Domain.DTO;
using ToDo.Domain.Model;
using ToDo.Infrastructure.Data;

namespace ToDo.Infrastructure.Repository
{
    public class EmploeyersRepository
    {
        private readonly Context _context;
        public EmploeyersRepository(Context context) => _context = context;

        public async Task<List<EmployeeDto>> GetEmploeyersListAsync()
        {
            List<Employee> employees = await _context.Employees.ToListAsync();

            List<EmployeeDto> dto = new();
            foreach (var employee in employees)
            {
                dto.Add(new EmployeeDto()
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Post = employee.Post
                });
            }
            return dto.ToList();
        }

        public async Task<EmployeeDto> GetCurrentEmploeyerAsync(Guid Id)
        {
            Employee employee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == Id);
            EmployeeDto dto = new()
            {
                Name = employee.Name,
                Post = employee.Post
            };
            return dto;
        }
    }
}
