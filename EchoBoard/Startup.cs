using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EchoBoard.Startup))]
namespace EchoBoard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
