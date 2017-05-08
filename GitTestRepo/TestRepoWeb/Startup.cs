using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestRepoWeb.Startup))]
namespace TestRepoWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
