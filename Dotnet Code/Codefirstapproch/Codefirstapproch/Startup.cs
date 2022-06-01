using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Codefirstapproch.Startup))]
namespace Codefirstapproch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
