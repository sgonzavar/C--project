using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebParcial.Startup))]
namespace WebParcial
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
