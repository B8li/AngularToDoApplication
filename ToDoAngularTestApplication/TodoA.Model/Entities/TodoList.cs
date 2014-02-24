using System;
using System.Collections;
using System.Collections.Generic;
using TodoA.Model.Entities.Base;

namespace TodoA.Model.Entities
{
    public class TodoList : Entity
    {
        public string Title { get; set; }

        public DateTime CreatedOn { get; set; }

        public virtual User Owner{get; set;}

        public virtual IList<TodoItem> Items { get; set; }


    }
}
