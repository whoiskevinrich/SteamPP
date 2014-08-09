using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SteamPP.Startup))]
namespace SteamPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
