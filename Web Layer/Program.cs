using DataAccess;
using Logic.Interfaces;
using Logic.Managers;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Stripe;
using System;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddScoped<ITicket, TicketRepository>();
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
StripeConfiguration.ApiKey = "sk_test_51OJI1sDIahZEuybpv2NkfiO0t440kElxNBhUhb5GAEbC28CAIGwCx4YAiczeVQqtcUJMUIWvOBuBMNQxX67YoL1G00VTeFsN5y";

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
