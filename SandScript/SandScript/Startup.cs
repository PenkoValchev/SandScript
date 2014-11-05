using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SandScript.Startup))]
namespace SandScript
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
