var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy( policity =>
    {
        policity
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
    }
);

var app = builder.Build();

app.UseCors();

app.MapGet("/", () =>
{
    return "API Sistema de Gestión funcionando";
});


app.MapGet("/api/cocteles", () =>
{
    return Results.Ok(new[]
    {
        new
        {
            dni = "72845631",
            nombre = "Juan",
            apellido = "Perez",
            curso = "Diseno Web",
            nota = 16
        },
        new
        {
            dni = "72845632",
            nombre = "Maria",
            apellido = "Lopez",
            curso = "Diseno Web",
            nota = 18
        },
        new
        {
            dni = "72845633",
            nombre = "Pedro",
            apellido = "Galbez",
            curso = "App",
            nota = 16
        },
        new
        {
            dni = "72845634",
            nombre = "Maria",
            apellido = "Mercedes",
            curso = "Intro",
            nota = 18
        }
    });
});


var port = Environment.GetEnvironmentVariable("Port") ?? "10000";

app.Run($"http://0.0.0.0:{port}");
