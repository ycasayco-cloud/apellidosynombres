var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policity =>
    {
        policity
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
    }
);

app.UseCors("AllowFrontEnd");

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


app.Run();
