using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMC.Startup))]
namespace TMC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
