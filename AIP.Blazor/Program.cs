using AIP.Blazor.Data;
using AIP.Plugins.InMemory;
using AIP.UseCases.PluginInterfaces;
using AIP.UseCases.Students;
using AIP.UseCases.Students.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
builder.Services.AddTransient<IViewStudentsByNameUseCase, ViewStudentsByNameUseCase>();
builder.Services.AddTransient<IAddStudentUseCase, AddStudentUseCase>();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
