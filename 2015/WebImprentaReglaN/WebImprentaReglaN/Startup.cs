using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebImprentaReglaN.Startup))]
namespace WebImprentaReglaN
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
