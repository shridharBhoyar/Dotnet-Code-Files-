using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(multimodelassestoview.Startup))]
namespace multimodelassestoview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
