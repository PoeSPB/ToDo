namespace ToDo.Domain.DTO
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Post { get; set; } = string.Empty;
    }
}
