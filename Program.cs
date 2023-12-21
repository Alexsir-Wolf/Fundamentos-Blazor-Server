using FundamentosBlazorServer.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//var conectionString = builder.Configuration.GetSection

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder
            .Configuration
            .GetSection("Settings")
            .GetSection("SQLServerSettings")
            .GetSection("ConnectionString").Value));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");	
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
