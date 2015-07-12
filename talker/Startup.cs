using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(talker.Startup))]
namespace talker
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
