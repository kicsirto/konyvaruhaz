using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(konyvaruhaz.Startup))]
namespace konyvaruhaz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
