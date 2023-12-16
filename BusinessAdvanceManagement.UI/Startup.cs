using BusinessAdvanceManagement.Core.APIService;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddFluentValidation(f => f.RegisterValidatorsFromAssemblyContaining<Startup>());


            services.AddSession(options =>
            {
                options.Cookie.Name = ".BusinessAdvanceManagement.Session";
                options.IdleTimeout = TimeSpan.FromMinutes(30); 
                options.Cookie.IsEssential = true;
            });


            services.AddHttpClient<GeneralApiService>(conf =>
            { conf.BaseAddress = new Uri(Configuration["MyBaseUri"]); });
            services.AddHttpClient<AuthApiService>(conf =>
            { conf.BaseAddress = new Uri(Configuration["MyBaseUri"]); });
            services.AddHttpClient<AdvanceRequestApiService>(conf =>
            { conf.BaseAddress = new Uri(Configuration["MyBaseUri"]); });
            services.AddHttpClient<AdvanceRequestDetailApiService>(conf =>
            { conf.BaseAddress = new Uri(Configuration["MyBaseUri"]); });
            services.AddHttpClient<RequestDetailApiService>(conf =>
            { conf.BaseAddress = new Uri(Configuration["MyBaseUri"]); });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Auth}/{action=Register}/{id?}");
            });
        }
    }
}
