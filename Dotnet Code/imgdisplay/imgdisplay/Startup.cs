using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(imgdisplay.Startup))]
namespace imgdisplay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
