using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Layoutt.Startup))]
namespace Layoutt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
