using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SlotManagement.Startup))]
namespace SlotManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
