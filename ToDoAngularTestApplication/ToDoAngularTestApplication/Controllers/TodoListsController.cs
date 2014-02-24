using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TodoA.Web.Controllers
{
    public class TodoListsController : Controller
    {
        //
        // GET: /TodoLists/
        public ActionResult Index()
        {
            return View();
        }
	}
}