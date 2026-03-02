using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskTracker.Core.Services;
using TaskTracker.Core.Storage;

namespace TaskTracker.Tests;

[TestClass]
public class ServiceTests
{
    [TestMethod]
    public void CreateTask_ShouldAddTask()
    {
        var storage = new MemoryTaskStorage();
        var service = new TaskService(storage);

        service.CreateTask("Test", "Desc");

        Assert.AreEqual(1, service.GetTasks().Count);
    }
}