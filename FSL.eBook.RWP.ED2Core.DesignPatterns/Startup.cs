using FSL.eBook.RWP.ED2Core.DesignPatterns.Models;
using FSL.eBook.RWP.ED2Core.DesignPatterns.RepositoryChapter;
using FSL.eBook.RWP.ED2Core.DesignPatterns.SingletonChapter;
using FSL.eBook.RWP.ED2Core.DesignPatterns.UnitOfWorkChapter;
using FSL.eBook.RWP.ED2Core.DesignPatterns.UnitOfWorkChapter.Scenario1;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns
{
    public class Startup
    {
        public Startup(
            IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            OptionsConfigurationServiceCollectionExtensions.Configure<EbookConfiguration>(
                services,
                Configuration.GetSection("EbookConfiguration"));

            services.UseRepository();
            services.UseUnitOfWorkScenario1();
            services.UseUnitOfWork();
            services.UseSingleton();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
