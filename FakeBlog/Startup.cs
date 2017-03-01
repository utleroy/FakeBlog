using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FakeBlog.Startup))]
namespace FakeBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
