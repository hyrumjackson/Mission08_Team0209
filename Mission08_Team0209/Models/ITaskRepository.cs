namespace Mission08_Team0209.Models
{
    public interface ITaskRepository
    {
        List<Task> Tasks { get; }

        public void AddTask(Task task);

    }
}
