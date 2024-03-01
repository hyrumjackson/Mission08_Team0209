namespace Mission08_Team0209.Models
{
    public interface ITaskRepository
    {
		IQueryable<Task> Tasks { get; }
		IQueryable<Category> Categories { get; }

		public void AddTask(Task task);
        public void UpdateTask(Task task);
        public void CompleteTask(int taskId);

    }
}
