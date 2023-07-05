using NLog;
using NLog.Web;
using NLogWeb.Models;
using Microsoft.EntityFrameworkCore;

var logger=NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddControllersWithViews();

    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    var connstr = builder.Configuration.GetConnectionString("conn");

    builder.Services.AddDbContext<EmployeeDbContext>(options =>
    options.UseSqlServer(connstr), ServiceLifetime.Singleton
    );
    builder.Services.AddSingleton<IEmployeeRepository, EmployeeMySqlRepo>();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseStatusCodePagesWithRedirects("/Error/{0}");
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }
    else
    {
        app.UseDeveloperExceptionPage();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    app.Run();
}
catch(Exception ex)
{
    logger.Error(ex,"Stopped Program Because of exception");
    throw;
}
finally
{
    NLog.LogManager.Shutdown();
}