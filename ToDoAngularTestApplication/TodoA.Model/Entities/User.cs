using System.Collections.Generic;
using TodoA.Model.Entities.Base;

namespace TodoA.Model.Entities
{
    public class User : Entity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public virtual IList<TodoList> Lists { get; set; }
    }
}
