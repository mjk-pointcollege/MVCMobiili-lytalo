using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMobiiliÄlytalo.Startup))]
namespace MVCMobiiliÄlytalo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
