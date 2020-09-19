using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvcproyect.Startup))]
namespace Mvcproyect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
