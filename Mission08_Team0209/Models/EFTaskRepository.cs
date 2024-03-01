namespace Mission08_Team0209.Models
{
    public class EFTaskRepository : ITaskRepository
    {
        private TaskContext _context;

        public EFTaskRepository(TaskContext temp)
        {
            _context = temp;
        }

        public IQueryable<Task> Tasks => _context.Tasks;
        public IQueryable<Category> Categories => _context.Categories;

        public void AddTask(Task task)
        {
            _context.Add(task);
            _context.SaveChanges();
        }

        public void UpdateTask(Task task)
        {
            _context.Tasks.Update(task);
            _context.SaveChanges();
        }

        public void CompleteTask(int taskId)
        {
            var task = _context.Tasks.Find(taskId);
            if (task != null)
            {
                task.Completed = true;
                _context.Tasks.Update(task);
                _context.SaveChanges();
            }
        }
    }
}
