using TaskTracker.Core.Services;

namespace TaskTracker.App.UI;

public class ConsoleUi
{
    private readonly TaskService _service;

    public ConsoleUi(TaskService service)
    {
        _service = service;
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("1 - Add task");
            Console.WriteLine("2 - Show tasks");
            Console.WriteLine("3 - Exit");

            var input = Console.ReadLine();

            if (input == "1")
                AddTask();
            else if (input == "2")
                ShowTasks();
            else if (input == "3")
                break;
        }
    }

    private void AddTask()
    {
        Console.Write("Title: ");
        var title = Console.ReadLine() ?? "";

        Console.Write("Description: ");
        var desc = Console.ReadLine() ?? "";

        if (_service.CreateTask(title, desc))
            Console.WriteLine("Task added!");
        else
            Console.WriteLine("Invalid task!");
    }

    private void ShowTasks()
    {
        var tasks = _service.GetTasks();

        foreach (var t in tasks)
            Console.WriteLine($"{t.Id} | {t.Title} | {t.Status}");
    }
}