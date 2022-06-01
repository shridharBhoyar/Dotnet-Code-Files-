using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InventoryProject.Startup))]
namespace InventoryProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
