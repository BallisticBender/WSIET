using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WSIET.Startup))]
namespace WSIET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
