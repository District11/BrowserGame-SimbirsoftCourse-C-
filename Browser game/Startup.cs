using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Browser_game.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IO;
using Browser_game.Models.Logger;
using Browser_game.Models;

namespace Browser_game
{
    public class Startup
    {
        private string path2= @"C:\Users\Азат\Documents\Visual Studio 2017\Projects\Browser game\logs\Data_logger.log";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            /// <summary>
            /// Аунтефикация пользователей в сервисах Google и Facebook с помощью OWIN
            /// </summary>         
            services.AddAuthentication()
               .AddGoogle(googleOptions =>
               {
                   googleOptions.ClientId = Configuration["Authentication:Google:ClientId"];
                   googleOptions.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
               })
                .AddFacebook(facebookOptions =>
            {
                facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
            });


           
            services.AddEntityFrameworkNpgsql()
                .AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders()
                .AddDefaultUI(UIFramework.Bootstrap4);


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            //задает режим совместимости в ASP.NET Core 2.2:
        }

        /// <summary>
        ///  // Этот метод вызывается во время выполнения. Используйте этот метод для настройки конвейера HTTP-запроса.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        /// <param name="loggerFactory"></param>
               public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            loggerFactory.AddFile(Path.Combine(Directory.GetCurrentDirectory(), path2));
            var logger = loggerFactory.CreateLogger("FileLogger");

            /// <summary>
            /// Установка обработчика ошибок
            /// </summary>
            app.UseHttpsRedirection();
            /// <summary>
            /// Установка обработчика статических файлов
            /// </summary>
            app.UseStaticFiles();
            /// <summary>
            /// Установка GDPR
            /// </summary>
            app.UseCookiePolicy();
            /// <summary>
            /// Установка аунтетификации
            /// </summary>
            app.UseAuthentication();
            /// <summary>
            /// Установка компонентов MVC для обработки запроса
            /// </summary>
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
