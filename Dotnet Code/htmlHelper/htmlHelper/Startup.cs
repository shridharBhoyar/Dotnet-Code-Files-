using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(htmlHelper.Startup))]
namespace htmlHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
