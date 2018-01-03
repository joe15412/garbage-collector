using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(garbagecollector.Startup))]
namespace garbagecollector
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
