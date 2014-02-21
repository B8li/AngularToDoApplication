using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoAngularTestApplication.Startup))]
namespace ToDoAngularTestApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
