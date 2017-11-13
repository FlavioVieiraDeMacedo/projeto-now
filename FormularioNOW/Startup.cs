using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FormularioNOW.Startup))]
namespace FormularioNOW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
