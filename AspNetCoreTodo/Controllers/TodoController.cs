using System.Net;
using AspNetCoreTodo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using AspNetCoreTodo.Services;

namespace AspNetCoreTodo.Controllers.Mvc
{
    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _todoItemService.GetIncompleteItemsAsync();
            // Get to-do items from database

            // Put items into a model
            var model = new TodoViewModel
            {
                Items = new List<TodoItem>()
            };

            var item = new TodoItem
            {
                DueAt =  new DateTimeOffset(new DateTime(2024, 7, 12)),
                Title = "This is a test item"
            };

            model.Items.Add(item);

            // Render view using the model
            return View(model);

        }
    }
}