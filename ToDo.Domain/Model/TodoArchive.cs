namespace ToDo.Domain.Model
{
    public class TodoArchive
    {
        public Guid Id { get; set; }
        public DateTime ArchivedDateTime { get; set; }
        public List<TodoEntry> TodoEntries { get; set; } = new();
    }
}
