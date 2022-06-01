using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(multipledataviewsingle.Startup))]
namespace multipledataviewsingle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
