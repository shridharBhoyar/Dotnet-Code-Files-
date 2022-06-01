using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InventrySystem.Startup))]
namespace InventrySystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
