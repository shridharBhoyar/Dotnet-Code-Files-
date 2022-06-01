using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sessionn.Startup))]
namespace sessionn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
