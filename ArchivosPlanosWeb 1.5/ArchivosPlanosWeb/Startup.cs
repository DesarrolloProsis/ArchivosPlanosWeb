using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArchivosPlanosWeb.Startup))]
namespace ArchivosPlanosWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
