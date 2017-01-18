using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarpoolMVC.Startup))]
namespace CarpoolMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
