using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Proje.ToDo.Web.Middlewares;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing.Constraints;
using Proje.ToDo.Web.Constraints;

namespace Proje.ToDo.Web
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
          
            services.AddSession();
            services.AddRazorPages();
            services.AddControllersWithViews();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseStatusCodePagesWithReExecute("/Home/PageError","?code={0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCustomStaticFile();

            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine
                (Directory.GetCurrentDirectory(),"node_modules")),
                RequestPath="/content"
            });

            app.UseRouting();
            app.UseSession();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern:"{area}/{controller=Home}/{action=Index}/{id?}"
                    );
                //endpoints.MapAreaControllerRoute(name: "areaAdmin",
                //    areaName: "Admin", 
                //    pattern: "{area}/{controller}/{action}");

                endpoints.MapControllerRoute(
                   name: "programmingRoute",
                   pattern: "programming/{language}",
                   defaults: new {controller="Home",action="Index"},
                   constraints: new {language=new Programming()}
                   );


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    //constraints: new {id=new IntRouteConstraint()}
                    );
            });
        }
    }
}
