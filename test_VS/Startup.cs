using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test_VS.Startup))]
namespace test_VS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
