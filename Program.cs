using TaskTracker.Core.Services;
using TaskTracker.Core.Storage;
using TaskTracker.App.UI;

var storage = new MemoryTaskStorage();
var service = new TaskService(storage);
var ui = new ConsoleUi(service);

ui.Run();