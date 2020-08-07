using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeddingPlannerApp.Startup))]
namespace WeddingPlannerApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
