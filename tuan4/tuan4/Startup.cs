using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tuan4.Startup))]
namespace tuan4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
