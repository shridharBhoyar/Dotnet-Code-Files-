using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataVie.Startup))]
namespace DataVie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
