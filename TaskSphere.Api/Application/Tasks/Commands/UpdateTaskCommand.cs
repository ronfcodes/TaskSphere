namespace TaskSphere.Api.Application.Tasks.Commands
{
    public class UpdateTaskCommand
    {
        public int TaskId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? Priority { get; set; }
        public DateTime? DateDue { get; set; }
        public bool? IsReminder { get; set; }
        public bool? IsCompleted { get; set; }
    }
}
