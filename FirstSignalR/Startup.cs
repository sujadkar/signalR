using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstSignalR.Startup))]
namespace FirstSignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
			app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
