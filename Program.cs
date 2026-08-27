var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

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

var port = Enviroment.GetEnviromentVariable("Port") ?? "10000";

app.Run($"https://0.0.0.0:{port}");
