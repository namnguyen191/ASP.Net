using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HTMLHelpers.Startup))]
namespace HTMLHelpers
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
