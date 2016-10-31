using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_one.Startup))]
namespace Vidly_one
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
