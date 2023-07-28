using Clubex2.Data;
using Clubex2.Interfaces;
using Clubex2.Models;
using Clubex2.Repositories;
using Clubex2.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

var _logger = new LoggerConfiguration()
    .MinimumLevel.Error()
    .WriteTo.File($"{builder.Environment.WebRootPath}\\Logs\\Log.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Logging.AddSerilog(_logger);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddScoped<ApplicationDbContext, ApplicationDbContext>();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(Constants.CookieName)
            .AddCookie(Constants.CookieName, options =>
            {
                options.Cookie.Name = Constants.CookieName;
                options.ExpireTimeSpan = TimeSpan.FromDays(365);
                options.Cookie.IsEssential = true;
            });

builder.Services.Configure<RecaptchaSettings>(builder.Configuration.GetSection("GoogleRecaptchaV3"));
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<HelperService>();
builder.Services.AddSingleton<UniqueCode>();
builder.Services.AddSingleton<CustomIDataProtection>();
builder.Services.AddSingleton<RecaptchaService>();
builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.AddTransient<IFileService, FileService>();
builder.Services.AddTransient<ITenantRepository, TenantRepository>();
builder.Services.AddHttpClient();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    //options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.Name = ".clubex";
    options.Cookie.Path = "/";
});

builder.Services.Configure<CookieTempDataProviderOptions>(options =>
{
    options.Cookie.Name = Constants.VisitorRef;
    options.Cookie.IsEssential = true;
    options.Cookie.Expiration = TimeSpan.FromDays(365);
});

builder.Services.AddAntiforgery(o =>
{
    o.HeaderName = "XSRF-TOKEN";
    o.SuppressXFrameOptionsHeader = false;
});

var app = builder.Build();

using (IServiceScope scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<ApplicationDbContext>();
        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

        var dbInitializerLogger = services.GetRequiredService<ILogger<DbInitializer>>();
        DbInitializer.Initialize(context, userManager, roleManager, dbInitializerLogger).Wait();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError("An error occurred while seeding the database.", ex);
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseSession();

app.UseTenant();

app.Use(async (context, next) =>
{
    context.Response.Headers.Add("X-XSS-Protection", "1; mode=block");
    context.Response.Headers.Add("X-Frame-Options", "DENY");
    context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
    //context.Response.Headers.Add("Strict-Transport-Security", "max-age=86400");
    context.Response.Headers.Add("Cache-Control", "no-cache");
    context.Response.Headers.Add("Referrer-Policy", "no-referrer");
    context.Response.Headers.Add("X-Permitted-Cross-Domain-Policies", "none");
    context.Response.Headers.Remove("X-Powered-By");

    await next();
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
