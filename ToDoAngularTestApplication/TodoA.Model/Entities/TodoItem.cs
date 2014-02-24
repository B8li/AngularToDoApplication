using System;
using TodoA.Model.Entities.Base;

namespace TodoA.Model.Entities
{
    public class TodoItem : Entity
    {
        public string Text { get; set; }
        
        public bool Status { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? FinishBefore { get; set; }

        public virtual TodoList List { get; set; }
    }
}
