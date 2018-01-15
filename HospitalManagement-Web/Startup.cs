using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HospitalManagement_Web.Startup))]
namespace HospitalManagement_Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
