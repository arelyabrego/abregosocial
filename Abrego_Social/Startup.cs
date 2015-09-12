using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Abrego_Social.Startup))]
namespace Abrego_Social
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
