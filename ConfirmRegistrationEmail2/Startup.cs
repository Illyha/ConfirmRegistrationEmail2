using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConfirmRegistrationEmail2.Startup))]
namespace ConfirmRegistrationEmail2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
