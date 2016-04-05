using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConnectStringCodeFirst.Startup))]
namespace ConnectStringCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
