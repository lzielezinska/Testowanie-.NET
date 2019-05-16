using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(school.Startup))]
namespace school
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
