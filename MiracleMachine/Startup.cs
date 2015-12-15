using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiracleMachine.Startup))]
namespace MiracleMachine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
