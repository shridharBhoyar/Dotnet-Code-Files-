using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataAnotation.Startup))]
namespace DataAnotation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
