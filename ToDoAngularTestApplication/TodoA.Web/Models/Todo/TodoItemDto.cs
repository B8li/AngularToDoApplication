using System;

namespace TodoA.Web.Models.Todo
{
    public class TodoItemDto
    {
        public string Text { get; set; }

        public bool Status { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? FinishBefore { get; set; }
    }
}