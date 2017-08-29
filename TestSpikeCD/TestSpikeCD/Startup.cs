using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestSpikeCD.Startup))]
namespace TestSpikeCD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
