using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PartialVieww.Startup))]
namespace PartialVieww
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
