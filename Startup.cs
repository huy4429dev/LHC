using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DVN.Data;
using Microsoft.Extensions.DependencyInjection.Extensions;
using DVN.Services;

namespace DVN
{
    public class Startup
    {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromDays(14); // thoi gian sống
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddMvc();

            // singelton service 

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // scope service

            services.AddScoped<UserService>();

            services.AddScoped<IMyScopedService, MyScopedService>();

            services.AddCronJob<MyCronJob1>(c =>
            {

                var now = DateTime.Now;
                string min = "0";
                string hourd = "0";
                var curentMonth = now.Month;
                var curentYear = now.Year;
                var lastDayofMonth = DateTime.DaysInMonth(curentYear, curentMonth);

                c.TimeZoneInfo = TimeZoneInfo.Local;
                c.CronExpression = @"50 12 * * *"; // format min / hour / day / month / dayOfWeek
            });
       
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles();

            app.UseSession();

            app.UseEndpoints(endpoints =>
                     {
                         endpoints.MapDefaultControllerRoute();
                     });

        }
    }
}
