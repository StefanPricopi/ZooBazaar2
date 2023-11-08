using DataAccess;
using Logic.Interfaces;
using Logic.Managers;
using Microsoft.AspNetCore.Authentication; // Import this namespace
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorPages();
builder.Services.AddScoped<IUser, UserRepository>();
builder.Services.AddScoped<UserManager>();
builder.Services.AddAuthentication().AddCookie("LoginCookieAuth", options =>
{
    options.Cookie.Name = "LoginCookieAuth";
    options.LoginPath = "/login";
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
