using System;
using System.Collections.Generic;
using System.Web.Http;
using TodoA.Web.Models.Todo;

namespace TodoA.Web.Controllers.api
{
    public class TodoListDataController : ApiController
    {
        #region Actions

        // GET api/<controller>
        public IEnumerable<TodoListDisplayDto> Get()
        {
            return GetTestTodoListData();
        }

        #endregion

        #region Mock Data

        private List<TodoListDisplayDto> GetTestTodoListData()
        {
            return new List<TodoListDisplayDto>()
            {
                GetSingleTodoListViewModel ("Groceries",  DateTime.Now.AddDays(-2), 2,  4 ),
                GetSingleTodoListViewModel ("Shopping",  DateTime.Now.AddDays(-4), 6,  2 ),
                GetSingleTodoListViewModel ("Work",  DateTime.Now.AddDays(-6), 1,  12 ),
                GetSingleTodoListViewModel ("Party",  DateTime.Now.AddDays(-1),  10,  20)
            };
        }

        private TodoListDisplayDto GetSingleTodoListViewModel(string title, DateTime dateCreated, int completedItems, int remainingItems)
        {
            return new TodoListDisplayDto()
            {
                Title = title,
                DateCreated = dateCreated,
                RemainingItems = remainingItems,
                CompletedItems = completedItems
            };
        }

        #endregion
    }
}