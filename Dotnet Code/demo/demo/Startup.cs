using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(demo.Startup))]
namespace demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
