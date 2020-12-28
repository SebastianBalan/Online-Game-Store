using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Online_Game_store.Startup))]
namespace Online_Game_store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
