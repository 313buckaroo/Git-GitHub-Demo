using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Git_GitHub_Demo.Startup))]
namespace Git_GitHub_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
