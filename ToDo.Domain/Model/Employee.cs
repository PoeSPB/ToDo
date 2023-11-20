namespace ToDo.Domain.Model
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Post { get; set; } = string.Empty;

        public List<TodoEntry> TodoEntries { get; set; }
        public List<PersonalTodo> PersonalTodo { get; set; } 
    }
}
