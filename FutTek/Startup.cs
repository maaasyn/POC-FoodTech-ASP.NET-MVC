using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FutTek.Startup))]
namespace FutTek
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
