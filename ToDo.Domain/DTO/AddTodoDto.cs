using ToDo.Domain.Model;

namespace ToDo.Domain.DTO
{
    public class AddTodoDto
    {
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public Guid ExecutorId { get; set; } = Guid.Empty;
        public Priority Priority { get; set; } = Priority.Low;
        public DateTime RunUntill { get; set; }
    }
}
