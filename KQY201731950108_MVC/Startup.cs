using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(task12.Startup))]
namespace task12
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
