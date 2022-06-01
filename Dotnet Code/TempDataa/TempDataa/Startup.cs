using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TempDataa.Startup))]
namespace TempDataa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
