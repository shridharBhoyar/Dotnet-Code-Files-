using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(entitymodel.Startup))]
namespace entitymodel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
