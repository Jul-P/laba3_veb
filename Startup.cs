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
using WebApplication1.Manager.Students;
using WebApplication1.Manager.Groups;
using WebApplication1.Manager.Hobbys;
using WebApplication1.Manager.Stependias;
using WebApplication1.Manager.Ratings;

using WebApplication1.Storege;
using WebApplication1.Controler;



namespace WebApplication1
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;
        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnviroment)
        {
            _configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnviroment.ContentRootPath).AddJsonFile("Dekanat.json").Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddDbContext<DekanatDataContext>(option => option.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
            services.AddTransient<IStudentManager, StudentManager>();
            services.AddTransient<IGroupManager, GroupManager>();
            services.AddTransient<IHobbyManager, HobbyManager>();
            services.AddTransient<IRatingManager, RatingManager>();
            services.AddTransient<IStependiaManager, StependiaManager>();
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
            app.UseStatusCodePages();
            app.UseMvcWithDefaultRoute();
            app.UseMvc(routs =>
            {
                routs.MapRoute(
                    name: "defoult",
                     template: "{controller=Student}/{action=ShowStudent}/{id?}"
                      
                    );
            });     
            }
           
        }
    }

