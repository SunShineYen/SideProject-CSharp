var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.Use(async (context, next) =>
{
    if (context.Request.Path == "/darkthread")
        await context.Response.WriteAsync("ASP.NET Core Rocks!");
    else
    {
        await next();
        await context.Response.WriteAsync(" Powered by ASP.NET Core");
    }
});
app.UseHttpsRedirection();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", async context =>
    {
        await context.Response.WriteAsync("Hello World!");
    });
    endpoints.MapGet("/darkthread", async context =>
    {
        await context.Response.WriteAsync("Handled by UseEndpoints");
    });
});
app.Run();
