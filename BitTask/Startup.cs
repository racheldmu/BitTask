using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BitTask.Startup))]
namespace BitTask
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
