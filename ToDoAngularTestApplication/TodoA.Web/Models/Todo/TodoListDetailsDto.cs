using System.Collections.Generic;

namespace TodoA.Web.Models.Todo
{
    public class TodoListDetailsDto:TodoListDisplayDto
    {
        public  List<TodoItemDto> Items { get; set; }
    }
}