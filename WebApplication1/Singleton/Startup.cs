using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Singleton.Startup))]
namespace Singleton
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
