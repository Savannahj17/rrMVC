using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestarurantRaterMVC.Startup))]
namespace RestarurantRaterMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
