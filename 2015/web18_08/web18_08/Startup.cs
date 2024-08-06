using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(web18_08.Startup))]
namespace web18_08
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
