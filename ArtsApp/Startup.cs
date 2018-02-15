using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArtsApp.Startup))]
namespace ArtsApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
