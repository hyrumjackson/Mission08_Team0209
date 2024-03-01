namespace Mission08_Team0209.Models
{
    public interface ITaskRepository
    {
		IQueryable<Task> Tasks { get; }
		IQueryable<Category> Categories { get; }

		public void AddTask(Task task);

    }
}
