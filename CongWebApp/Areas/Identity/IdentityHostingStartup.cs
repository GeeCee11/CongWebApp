using System;
using CongWebApp.Areas.Identity.Data;
using CongWebApp.Data;
using CongWebApp.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CongWebApp.Areas.Identity.IdentityHostingStartup))]
namespace CongWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CongWebAppContext>(options =>
                    options.UseMySql(
                        context.Configuration.GetConnectionString("CongWebAppContextConnection")));

                //services.AddDefaultIdentity<CongWebAppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //    .AddEntityFrameworkStores<CongWebAppContext>();
            });
        }
    }
}