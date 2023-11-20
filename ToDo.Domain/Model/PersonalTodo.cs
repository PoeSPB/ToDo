namespace ToDo.Domain.Model
{
    public class PersonalTodo
    {
        public Guid Id { get; set; }

        public Employee EmployeeId { get; set; }
        public List<TodoEntry> TodoEntries { get; set; } = new();
    }
}
