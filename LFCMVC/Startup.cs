using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LFCMVC.Startup))]
namespace LFCMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
