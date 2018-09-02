using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(IoT_Dashboard.Startup))]
namespace IoT_Dashboard
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}