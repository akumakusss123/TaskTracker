using TaskTracker.Core.Models;

namespace TaskTracker.Core.Validation;

public static class TaskValidator
{
    public static bool Validate(TaskItem task)
    {
        if (string.IsNullOrWhiteSpace(task.Title))
            return false;

        if (task.Title.Length < 3)
            return false;

        return true;
    }
}