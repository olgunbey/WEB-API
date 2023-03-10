using WebAPP.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient<ProductApiService>(x =>
{
    x.BaseAddress = new Uri("https://localhost:7297/api/");
}
);
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
app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());
app.UseAuthorization();

app.MapRazorPages();

app.Run();
