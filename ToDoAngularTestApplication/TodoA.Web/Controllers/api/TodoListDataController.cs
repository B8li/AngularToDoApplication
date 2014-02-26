using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mime;
using System.Web.Http;
using TodoA.Model.Entities;
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

        // GET api/<controller>
        public TodoListDetailsDto Get(int id)
        {
            return GetDetailsDto(id);
        }

        #endregion

        #region Mock Data


        #region Lists

        private IEnumerable<TodoListDisplayDto> GetTestTodoListData()
        {
            return new List<TodoListDisplayDto>()
            {
                GetSingleTodoListViewModel (1, "Groceries",  DateTime.Now.AddDays(-2), 2,  4 ),
                GetSingleTodoListViewModel (2, "Shopping",  DateTime.Now.AddDays(-4), 6,  2 ),
                GetSingleTodoListViewModel (3, "Work",  DateTime.Now.AddDays(-6), 1,  12 ),
                GetSingleTodoListViewModel (4, "Party",  DateTime.Now.AddDays(-1),  10,  20)
            };
        }

        private TodoListDisplayDto GetSingleTodoListViewModel(int id, string title, DateTime dateCreated, int completedItems, int remainingItems)
        {
            return new TodoListDisplayDto()
            {
                Id = id,
                Title = title,
                DateCreated = dateCreated,
                RemainingItems = remainingItems,
                CompletedItems = completedItems
            };
        }

        #endregion

        #region List Details and Items

        private TodoListDetailsDto GetDetailsDto(int id)
        {
            var list = GetTestTodoListData().FirstOrDefault(t => t.Id == id);

            if (list == null)
            {
                return null;
            }
            else
            {
                return new TodoListDetailsDto()
                {
                    Title = list.Title,
                    CompletedItems = list.CompletedItems,
                    RemainingItems = list.RemainingItems,
                    DateCreated = list.DateCreated,
                    Id = id,
                    Items = GenerateTodoItems()
                };
            }
        }

        private List<TodoItemDto> GenerateTodoItems()
        {
            return new List<TodoItemDto>()
            {
                GetTodoItemDto("Run", false, DateTime.Now.AddDays(-10),null),
                GetTodoItemDto("Ride Bikes", false, DateTime.Now.AddDays(-2),DateTime.Now.AddDays(6)),
                GetTodoItemDto("Learn Angular", true, DateTime.Now.AddDays(-3),null),
                GetTodoItemDto("Solution", true, DateTime.Now.AddDays(-4),null),
                GetTodoItemDto("Watch Kevin Heart", true, DateTime.Now.AddDays(-5),DateTime.Now.AddDays(5)),
                GetTodoItemDto("Drink Coffeee", false, DateTime.Now.AddDays(-11), DateTime.Now.AddDays(2)),
            };
        }

        private TodoItemDto GetTodoItemDto(string text, bool status, DateTime createTime, DateTime? finishBefore)
        {
            return new TodoItemDto()
            {
                Text = text,
                Status = status,
                CreatedOn = createTime,
                FinishBefore = finishBefore
            };
        }

        #endregion

        #endregion
    }
}