using System;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TodoA.Web.Infrastructure.CustomResults
{
    /// <summary>
    /// Custom Json result that uses indent formating and ISO date standard for parsing dates.
    /// </summary>
    public class IsoDateJsonResult : JsonResult
    {
        public JsonSerializerSettings SerializerSettings { get; set; }

        public Formatting Formatting { get; set; }

        public IsoDateJsonResult(object data, string contentType, Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            ContentType = contentType;
            ContentEncoding = contentEncoding;
            JsonRequestBehavior = behavior;

            SerializerSettings = new JsonSerializerSettings();

            SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

            SerializerSettings.Converters.Add(new IsoDateTimeConverter());

            SerializerSettings.Formatting = Formatting.Indented;

            Data = data;
        }

        /// <summary>
        /// Enables processing of the result of an action method by a custom type that inherits from the <see cref="T:System.Web.Mvc.ActionResult"/> class.
        /// </summary>
        /// <param name="context">The context in which the result is executed. The context information includes the controller, HTTP content, request context, and route data.</param>
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            HttpResponseBase response = context.HttpContext.Response;

            // Add "application/json" as content header
            response.ContentType = !string.IsNullOrEmpty(ContentType) ? ContentType : "application/json";

            if (ContentEncoding != null)
                response.ContentEncoding = ContentEncoding;

            // If we have data, serialize it
            if (Data != null)
            {
                var writer = new JsonTextWriter(response.Output) { Formatting = Formatting };
                var serializer = JsonSerializer.Create(SerializerSettings);
                serializer.Serialize(writer, Data);
                writer.Flush();
            }
        }
    }
}