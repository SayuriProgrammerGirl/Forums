using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaladForum.Startup))]
namespace SaladForum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
