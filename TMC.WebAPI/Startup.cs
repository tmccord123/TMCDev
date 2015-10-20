using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMC.Web.Startup))]
namespace TMC.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
