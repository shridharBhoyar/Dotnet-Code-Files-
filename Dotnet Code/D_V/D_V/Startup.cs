using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(D_V.Startup))]
namespace D_V
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
