using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(delete.Startup))]
namespace delete
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
