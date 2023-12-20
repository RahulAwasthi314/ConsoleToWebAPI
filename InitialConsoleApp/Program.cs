using System.Reflection.Metadata.Ecma335;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => {
    return "The webApp is running";
});

app.Run();
