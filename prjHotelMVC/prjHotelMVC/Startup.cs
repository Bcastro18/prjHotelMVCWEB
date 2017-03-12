using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prjHotelMVC.Startup))]
namespace prjHotelMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
