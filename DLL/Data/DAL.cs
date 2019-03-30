using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bg_DAL.Data;
using Bg_DAL.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Bg_DAL.Services.Implementation;


namespace Bg_DAL.Data
{
    public static class DAL 
    {
        public static IServiceCollection AddDAL(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddEntityFrameworkNpgsql().AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IPlayerDataServices, PlayerDataServices>();
            return services;
        }
    }
}
