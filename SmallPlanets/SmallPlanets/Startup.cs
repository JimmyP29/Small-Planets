using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmallPlanets.Startup))]
namespace SmallPlanets
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
