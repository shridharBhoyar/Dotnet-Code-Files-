using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(createUpdate.Startup))]
namespace createUpdate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
