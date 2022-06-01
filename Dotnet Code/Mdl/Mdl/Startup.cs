using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mdl.Startup))]
namespace Mdl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
