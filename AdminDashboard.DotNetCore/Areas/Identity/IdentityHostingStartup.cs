using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(AdminDashboard.DotNetCore.Areas.Identity.IdentityHostingStartup))]
namespace AdminDashboard.DotNetCore.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}