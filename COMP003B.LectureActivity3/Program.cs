/*
    Author: Sumei Zhang
    Course: COMP-003B: ASP.NET Core
    Faculty: Jonathan Cruz
    Purpose: Demonstrates routing, model binding, and validation in ASP.NET Core MVC.
*/

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Conventional routing defaults to the Home controller and Index action.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
