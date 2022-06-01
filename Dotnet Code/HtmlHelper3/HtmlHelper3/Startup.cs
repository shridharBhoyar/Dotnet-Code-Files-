using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HtmlHelper3.Startup))]
namespace HtmlHelper3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
