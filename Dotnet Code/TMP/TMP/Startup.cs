using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMP.Startup))]
namespace TMP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
