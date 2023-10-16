using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FIT5032_Assignment_Portfolio_V1._0.Startup))]
namespace FIT5032_Assignment_Portfolio_V1._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            {
                app.MapSignalR();
            }
        }
    }
}
