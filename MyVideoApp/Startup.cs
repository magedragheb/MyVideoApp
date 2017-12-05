using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyVideoApp.Startup))]
namespace MyVideoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
