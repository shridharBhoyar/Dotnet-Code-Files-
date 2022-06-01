using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(update.Startup))]
namespace update
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
