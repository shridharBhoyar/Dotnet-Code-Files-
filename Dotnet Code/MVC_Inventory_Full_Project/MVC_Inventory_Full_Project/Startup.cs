using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Inventory_Full_Project.Startup))]
namespace MVC_Inventory_Full_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
