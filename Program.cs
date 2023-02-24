using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using static System.Collections.Specialized.BitVector32;
using WebApplication1.Models.DataSourses;
using WebApplication1.Models.Abstraction;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<IFilmDataSourse, FilmDatabase>();

            // Add services to the container.
            builder.Services.AddMvc().AddRazorRuntimeCompilation();

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

            app.UseRouting();

            app.UseAuthorization();



            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action}");

            app.MapControllerRoute(
            name: "NotFound",
                pattern: "{*url}",
                new { controller = "Special", action = "NotFoundPage" }
            );

            app.Run();
        }
    }
}