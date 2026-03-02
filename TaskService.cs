using TaskTracker.Core.Models;
using TaskTracker.Core.Storage;
using TaskTracker.Core.Validation;

namespace TaskTracker.Core.Services;

public class TaskService
{
    private readonly ITaskStorage _storage;

    public TaskService(ITaskStorage storage)
    {
        _storage = storage;
    }

    public bool CreateTask(string title, string description)
    {
        var task = new TaskItem
        {
            Title = title,
            Description = description
        };

        if (!TaskValidator.Validate(task))
            return false;

        _storage.Add(task);
        return true;
    }

    public List<TaskItem> GetTasks() => _storage.GetAll();

    public void DeleteTask(Guid id) => _storage.Delete(id);
}