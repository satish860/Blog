using Microsoft.EntityFrameworkCore;
using Blog.Web.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient<IRepository, Repository>();

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;

})
     .AddRoles<IdentityRole>()
     .AddEntityFrameworkStores<AppDbContext>();
builder.Services.AddAuthentication()
    .AddCookie(options =>
    {
        options.LoginPath = "Auth/Login";
    });

var app = builder.Build();

var scope = app.Services.CreateScope();

var ctx = scope.ServiceProvider.GetService<AppDbContext>();
var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

ctx.Database.EnsureCreated();

var adminRole = new IdentityRole("Admin");
if (!ctx.Roles.Any())
{
    roleManager.CreateAsync(adminRole).GetAwaiter().GetResult();
}

if (!ctx.Users.Any(p => p.UserName == "admin"))
{
    var adminUser = new IdentityUser
    {
        UserName = "admin",
        Email = "admin@admintest.com",
    };
    userManager.CreateAsync(adminUser, "password").GetAwaiter().GetResult();
    userManager.AddToRoleAsync(adminUser, adminRole.Name).GetAwaiter().GetResult();
}


app.UseRouting();
app.UseAuthentication();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();