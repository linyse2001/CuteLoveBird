var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Serve all files from the "wwwroot" folder
app.UseDefaultFiles();        // automatically looks for index.html
app.UseStaticFiles();

app.Run();
