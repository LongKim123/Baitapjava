using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tuan3.Startup))]
namespace tuan3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
