using System;

namespace TodoA.Web.Models.Todo
{
    /// <summary>
    /// The DTO used to display simple information for user to do lists
    /// </summary>
    public class TodoListDisplayDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime DateCreated { get; set; }

        public int RemainingItems { get; set; }

        public int CompletedItems { get; set; }
    }
}