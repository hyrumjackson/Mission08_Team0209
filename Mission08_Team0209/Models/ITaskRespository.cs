namespace Mission08_Team0209.Models
{
    public interface ITaskRespository
    {
        List<Task> Tasks { get; }

        public void AddTask(Task task);

    }
}
