using System.Text;
using System.Web.Mvc;
using TodoA.Web.Infrastructure.CustomResults;

namespace TodoA.Web.Controllers.Base
{
    /// <summary>
    /// Extensions for the base MVC Controller. This is mainly used to fix the issue with the json dates as serialized 
    /// by the base formatter
    /// </summary>
    public class BaseController : Controller
    {
        protected override JsonResult Json(object data, string contentType, Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new IsoDateJsonResult(data, contentType, contentEncoding, behavior);
        }

        protected override JsonResult Json(object data, string contentType, Encoding contentEncoding)
        {
            return new IsoDateJsonResult(data, contentType, contentEncoding, JsonRequestBehavior.DenyGet);
        }
    }
}