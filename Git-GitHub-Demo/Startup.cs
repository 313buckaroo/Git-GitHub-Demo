using Microsoft.Owin;
using Owin;
//I can do all things through Christ who strengthens me (Phillipians 4:13).
//Even Learn C#, Azure, Git, Github, Visual Studio, Asp.Net, SQL, Wordpress, and Web Development.
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
