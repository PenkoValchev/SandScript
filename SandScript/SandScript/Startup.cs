using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SandScript.Web.Startup))]
namespace SandScript.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
