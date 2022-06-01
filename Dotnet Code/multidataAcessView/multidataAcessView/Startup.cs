using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(multidataAcessView.Startup))]
namespace multidataAcessView
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
