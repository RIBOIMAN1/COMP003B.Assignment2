/*
 * Name: Riley Benson
 * Course name: COMP-003B: ASP.NET Core
 * Faculty name: Jonathan Cruz
 * Purpose: To showcase my ability to build a structured and modular ASP.NET Core MVC web application.
 */
namespace COMP003B.Assignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
			app.UseMiddleware<COMP003B.Assignment2.Middleware.RequestTrackerMiddleware>();
			app.UseWelcomePage("/welcome");

            app.UseMiddleware<COMP003B.Assignment2.Middleware.RequestTrackerMiddleware>();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}