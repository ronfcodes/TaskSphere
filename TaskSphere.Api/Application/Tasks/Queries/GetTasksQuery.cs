namespace TaskSphere.Api.Application.Tasks.Queries
{
    public class GetTasksQuery
    {
        public int? MinPriority { get; set; }
        public int? MaxPriority { get; set; }
        public bool? OnlyCompleted { get; set; }
        public DateTime? DueBefore { get; set; }
        public DateTime? DueAfter { get; set; }
    }
}
