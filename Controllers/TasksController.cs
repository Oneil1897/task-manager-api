using Microsoft.AspNetCore.Mvc;
using TaskManagerAPI.Services;
using TaskManagerAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskManagerAPI.Controllers
{
    [ApiController]
    [Route("api/tasks")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public async Task<IEnumerable<TaskItem>> GetTasks()
        {
            return await _taskService.GetAllTasksAsync();
        }

        [HttpPost]
        public async Task<ActionResult<TaskItem>> CreateTask(TaskItem task)
        {
            await _taskService.AddTaskAsync(task);
            return CreatedAtAction(nameof(GetTasks), new { id = task.Id }, task);
        }
    }
}
