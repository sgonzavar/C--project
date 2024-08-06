using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webAgencia.Startup))]
namespace webAgencia
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
