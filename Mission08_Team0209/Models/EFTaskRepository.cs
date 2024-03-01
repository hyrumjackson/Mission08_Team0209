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
    }
}
