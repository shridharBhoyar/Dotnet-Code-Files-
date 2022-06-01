using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(addition.Startup))]
namespace addition
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
