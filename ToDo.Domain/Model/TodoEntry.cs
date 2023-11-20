namespace ToDo.Domain.Model
{
    public enum TaskStatus
    {
        Null, //Не взято
        Started, //Начато
        InProgress, //В процессе
        Success //Завершено
    }
    public enum Priority
    {
        Low, //Низкий
        Medium, //Средний
        High, //Высокий
        Critical //Критичный
    }
    public class TodoEntry
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ExecutorId { get; set; } = Guid.Empty;
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public Priority Priority { get; set; } = Priority.Low;
        public TaskStatus Status { get; set; } = TaskStatus.Null;
        public DateTime Issued { get; set; } = DateTime.Now; //Создано
        public DateTime TakenOn { get; set; } //Взято в работу
        public DateTime CompletedAt { get; set; } //Завершено
        public DateTime RunUntill { get; set; } //Выполнить до

        public PersonalTodo PersonalTodo { get; set; }
    }
}
