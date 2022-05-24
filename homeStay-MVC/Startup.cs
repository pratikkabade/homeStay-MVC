using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(homeStay_MVC.Startup))]
namespace homeStay_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
