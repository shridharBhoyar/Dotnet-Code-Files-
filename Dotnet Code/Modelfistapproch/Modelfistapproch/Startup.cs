using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Modelfistapproch.Startup))]
namespace Modelfistapproch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
