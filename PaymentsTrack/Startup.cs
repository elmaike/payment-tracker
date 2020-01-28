using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaymentsTrack.Startup))]
namespace PaymentsTrack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
