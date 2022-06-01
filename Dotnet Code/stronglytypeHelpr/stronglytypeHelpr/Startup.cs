using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(stronglytypeHelpr.Startup))]
namespace stronglytypeHelpr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
