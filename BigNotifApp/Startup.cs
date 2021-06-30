using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigNotifApp.Startup))]
namespace BigNotifApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
