using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Outlook_Mail.Startup))]
namespace Outlook_Mail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
