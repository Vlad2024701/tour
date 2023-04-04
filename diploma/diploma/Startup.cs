using diploma.Db.Tour;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace diploma
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddDbContext<TourContext>(options => options.UseSqlServer("TourDatabase"));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var routeBuilder = new RouteBuilder(app);

            //routeBuilder.MapRoute("{controller}/{action}",
            //    async context =>
            //    {
            //        context.Response.ContentType = "text/html; charset=utf-8";
            //        await context.Response.WriteAsync("xd");
            //    });
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseMvcWithDefaultRoute();
            
            app.UseRouter(routeBuilder.Build());

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello");
            });
        }

        public void ConfigureRoute(IRouteBuilder routeBuilder) 
        {
            routeBuilder.MapRoute("Default", "{controller = Home}/{action = Index}/{id?}");    

        }
    }
}
