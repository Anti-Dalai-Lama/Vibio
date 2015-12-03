using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vibio.Startup))]
namespace Vibio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}