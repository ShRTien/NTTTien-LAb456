using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenThithuyTien_Lab456.Startup))]
namespace NguyenThithuyTien_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
