using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RistoranteMVC.Auth;
using RistoranteMVC.Models;
using RistoranteMVC.Repositories;

namespace RistoranteMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<RistoranteMVCDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("RistoranteMVCConnectionString")));

            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<RistoranteMVCDbContext>().AddDefaultTokenProviders();

            services.AddScoped<IDishRepository, DishRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IAccountRepository, AccountRepository>();

            services.AddControllersWithViews();      
        }



        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "categoryfilter",
                    pattern: "{controller=Dish}/{action=List}/{categoryId?}");
            });

        }
    }
}