using koishowweb;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DbContextKoi>(options =>
         options.UseSqlServer(builder.Configuration["connectionString"]));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
    app.UseSwagger();
    app.UseSwaggerUI();
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    //app.UseSwaggerUI(options =>
    //{
    //    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    //    options.RoutePrefix = string.Empty;
    //});
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/mycoolapi/swagger/v1/swagger.json", "My Cool API V1");
        c.RoutePrefix = "mycoolapi/swagger";
    });
}
app.UseSwagger();
app.UseSwaggerUI();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = "swagger/docs";
});



app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
