using ToDo.Domain.Model;

namespace ToDo.Domain.DTO
{
    public class TodoEntryDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Executor { get; set; } = string.Empty;
        public Priority Priority { get; set; }
        public DateTime Issued { get; set; } = DateTime.Now; //Создано
        public DateTime RunUntill { get; set; }
    }
}
