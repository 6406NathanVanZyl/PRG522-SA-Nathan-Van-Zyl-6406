using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PRG522_SA_Nathan_Van_Zyl_6406.Startup))]
namespace PRG522_SA_Nathan_Van_Zyl_6406
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
