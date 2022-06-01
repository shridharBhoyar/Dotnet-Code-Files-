using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViewBagg.Startup))]
namespace ViewBagg
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
