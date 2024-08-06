using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(pWebDSI54.Startup))]
namespace pWebDSI54
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
