using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sale_puchase.Startup))]
namespace sale_puchase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
