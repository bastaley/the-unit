using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheUnit.Startup))]
namespace TheUnit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
