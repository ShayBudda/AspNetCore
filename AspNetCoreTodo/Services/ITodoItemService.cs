using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;

namespace AspNetCoreTodo.Services
{
    public interface ITodoItemService
    {
        // This method requires no parameters and returns a Task<TodoItem[]>
        Task<TodoItem[]> GetIncompleteItemsAsync();
    }
}