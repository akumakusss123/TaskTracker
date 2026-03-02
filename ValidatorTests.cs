using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskTracker.Core.Models;
using TaskTracker.Core.Validation;

namespace TaskTracker.Tests;

[TestClass]
public class ValidatorTests
{
    [TestMethod]
    public void EmptyTitle_ShouldReturnFalse()
    {
        var task = new TaskItem { Title = "" };
        var result = TaskValidator.Validate(task);
        Assert.IsFalse(result);
    }
}