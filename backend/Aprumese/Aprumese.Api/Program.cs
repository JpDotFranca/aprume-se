WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();
 
app.MapGet("/", () =>
{
    string result = "Hello, World 2!";
     
    return result;
});

app.Run();
 