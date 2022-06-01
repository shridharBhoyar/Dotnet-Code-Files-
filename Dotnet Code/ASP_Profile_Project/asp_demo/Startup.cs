using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp_demo.Startup))]
namespace asp_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
