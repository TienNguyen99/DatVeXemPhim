using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatVeXemPhim.Startup))]
namespace DatVeXemPhim
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
