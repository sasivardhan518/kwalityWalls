using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KwalityWalls.Startup))]
namespace KwalityWalls
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
