using TaskTracker.Core.Models;

namespace TaskTracker.Core.Storage;

public interface ITaskStorage
{
    void Add(TaskItem task);
    List<TaskItem> GetAll();
    void Delete(Guid id);
    void Update(TaskItem task);
}