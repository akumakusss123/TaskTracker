using TaskTracker.Core.Models;

namespace TaskTracker.Core.Storage;

public class MemoryTaskStorage : ITaskStorage
{
    private readonly List<TaskItem> _tasks = new();

    public void Add(TaskItem task) => _tasks.Add(task);

    public List<TaskItem> GetAll() => _tasks;

    public void Delete(Guid id)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
            _tasks.Remove(task);
    }

    public void Update(TaskItem task)
    {
        var existing = _tasks.FirstOrDefault(t => t.Id == task.Id);
        if (existing != null)
        {
            existing.Title = task.Title;
            existing.Description = task.Description;
            existing.Status = task.Status;
        }
    }
}