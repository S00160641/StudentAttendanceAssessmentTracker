using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RadProject.Startup))]
namespace RadProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
