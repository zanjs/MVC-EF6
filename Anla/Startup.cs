using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Anla.Startup))]
namespace Anla
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
