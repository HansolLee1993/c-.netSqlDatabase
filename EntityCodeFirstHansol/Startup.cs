using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityCodeFirstHansol.Startup))]
namespace EntityCodeFirstHansol
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
