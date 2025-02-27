var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hej! Mitt namn är Albin Stenhoff.");

app.Run();
