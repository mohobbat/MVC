using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DropdownApp.Startup))]
namespace DropdownApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
