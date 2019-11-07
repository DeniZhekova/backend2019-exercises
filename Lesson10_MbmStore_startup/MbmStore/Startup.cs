using System;
using MbmStore.Data;
using MbmStore.Models.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MbmStore
{
    public class Startup
    {

        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
            services.AddDbContext<MbmStoreContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("MbmStoreContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }

            app.UseStaticFiles();
            app.UseSession();
            

            app.UseMvc(routes =>
            {

                 routes.MapRoute(
                    name : "areas",
                    template : "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );


                routes.MapRoute(
                    name: null,
                    template: "Catalogue/{category}/Page{page:int}",
                    defaults: new
                    {
                        controller = "Catalogue",
                        action = "Index" }
                    );

                routes.MapRoute(
                    name: null,
                    template: "Page{page:int}",
                    defaults: new
                    {
                        controller = "Catalogue",
                        action = "Index",
                        productPage = 1
                    });

                routes.MapRoute(
                    name: null,
                    template: "Catalogue/{category}",
                    defaults: new
                    {
                        controller = "Catalogue",
                        action = "Index",
                        productPage = 1
                    });

                routes.MapRoute(
                    name: null,
                    template: "",
                    defaults: new
                    {
                        controller = "Catalogue",
                        action = "Index",
                        productPage = 1
                    });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Catalogue}/{action=Index}/{id?}");
                });
        }
    }
}
