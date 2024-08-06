using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webClienteBD.Startup))]
namespace webClienteBD
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
