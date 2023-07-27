using asp.net_core_basic.Services;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Globalization;
namespace asp.net_core_basic
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        public void ConfigureServices(IServiceCollection services)
        {
            // Diðer servisleri ekleyin...

            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();

            services.AddControllersWithViews();

            //jsonplaceholder service
            services.AddHttpClient();
            services.AddScoped<JsonPlaceholderService>();

        }

        public void Configure(IApplicationBuilder app)
        {
            if (!app.ApplicationServices.GetRequiredService<IWebHostEnvironment>().IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();


            var suppertedCultures = new[]
            {"tr-TR","en-US"};

            var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(suppertedCultures[0])
                .AddSupportedCultures(suppertedCultures)
                .AddSupportedUICultures(suppertedCultures);


            app.UseRequestLocalization(localizationOptions);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}