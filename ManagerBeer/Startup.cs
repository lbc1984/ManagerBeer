using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManagerBeer.Startup))]
namespace ManagerBeer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
