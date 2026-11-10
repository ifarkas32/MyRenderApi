var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from C# running on Render!");

app.MapGet("/weather", () => new
{
    City = "Budapest",
    Temperature = 22,
    Unit = "C"
});

app.Run();