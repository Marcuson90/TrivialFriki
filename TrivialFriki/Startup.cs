using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrivialFriki.Startup))]
namespace TrivialFriki
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
