using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZephyrUI.Startup))]
namespace ZephyrUI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
