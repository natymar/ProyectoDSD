using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AplicacionWebLibreria.Startup))]
namespace AplicacionWebLibreria
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
