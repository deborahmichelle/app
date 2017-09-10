using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fine_art.Startup))]
namespace fine_art
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
