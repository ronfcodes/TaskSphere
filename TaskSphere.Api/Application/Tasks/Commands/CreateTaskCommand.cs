namespace TaskSphere.Api.Application.Tasks.Commands
{
    public class CreateTaskCommand
    {
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Priority { get; set; }
        public DateTime? DateDue { get; set; }
        public bool IsReminder { get; set; }
    }
}
