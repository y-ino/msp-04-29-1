using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(msp_04_29_1.Startup))]
namespace msp_04_29_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
