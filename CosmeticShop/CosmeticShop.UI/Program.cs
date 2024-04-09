using CosmeticShop.UI.Extensions;

var builder = WebApplication.CreateBuilder(args);

#region Services
builder.Services.AddControllersWithViews();

builder.Services.LoadMyDbContextServices();

builder.Services.LoadMyIdentityServices();

builder.Services.LoadMyRepository();

builder.Services.LoadMyOtherService();



#endregion



var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UpdateDatabase().Run();
