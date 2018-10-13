using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuanLyVeSo.Startup))]
namespace QuanLyVeSo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
