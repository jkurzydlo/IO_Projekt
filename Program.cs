using ksiegarniaAp;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
var connectionString = "Server=localhost;Database=DBKsiegarnia;Trusted_Connection=True;TrustServerCertificate=True";

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(op => op.UseSqlServer("Server=localhost;Database=DBKsiegarnia;Trusted_Connection=True;TrustServerCertificate=True"));
builder.Services.AddAuthorizationBuilder()
    .AddPolicy("admin", policy => policy.RequireRole("admin"))
    .AddPolicy("user", policy => policy.RequireRole("user"));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false).
	AddRoles<IdentityRole>().
	AddEntityFrameworkStores<AppDbContext>().
	AddErrorDescriber<LocalizedIdentityErrorDescriber>();
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
app.MapRazorPages();
app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
