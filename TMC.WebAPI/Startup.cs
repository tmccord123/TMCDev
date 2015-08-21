using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMC.WebAPI.Startup))]
namespace TMC.WebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
