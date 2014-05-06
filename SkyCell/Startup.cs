using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkyCell.Startup))]
namespace SkyCell
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
