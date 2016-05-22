using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASM.ECOMMERCE.WEB.Startup))]
namespace ASM.ECOMMERCE.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
