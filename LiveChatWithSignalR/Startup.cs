using Owin;
using Microsoft.Owin;
[assembly: OwinStartup(typeof(LiveChatWithSignalR.Startup))]

namespace LiveChatWithSignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            app.MapSignalR();
        }
    }
}