using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VetChat.Areas.Identity.Data;
using VetChat.Data;

[assembly: HostingStartup(typeof(VetChat.Areas.Identity.IdentityHostingStartup))]

namespace VetChat.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<VetChatContext>(options =>
                options.UseSqlServer(
                    context.Configuration.GetConnectionString("VetChatContextConnection")));

                services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<VetChatContext>();
            });
        }
    }
}