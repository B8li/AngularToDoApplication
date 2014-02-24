using System.Data.Entity;
using TodoA.Model.Entities;

namespace TodoA.Model.Context
{
    public class TodoAContext : DbContext
    {

        /// <summary>
        /// Constructor that will define the specific connetion string
        /// </summary>
        public TodoAContext()
            : base("TodoA")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<TodoList> TodoLists { get; set; }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
