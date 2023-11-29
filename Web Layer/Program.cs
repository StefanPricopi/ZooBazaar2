using DataAccess;
using Logic.Interfaces;
using Logic.Managers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddScoped<IUser, UserRepository>();
builder.Services.AddScoped<UserManager>();
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = "LoginCookieAuth";
    options.DefaultChallengeScheme = "LoginCookieAuth";
})
.AddCookie("LoginCookieAuth", options =>
{
    options.Cookie.Name = "LoginCookieAuth";
    options.LoginPath = "/login";
    options.AccessDeniedPath = "/index";
});
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("MustBeEmployee",
        policy => policy.RequireClaim("Employee", "Caretaker"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
