using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySugarStudioWebsite.Startup))]
namespace MySugarStudioWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
