using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

// ============================================================
// MODELO
// ============================================================

public class Ropa
{
    public int Id { get; set; }
    public string Codigo { get; set; } = "";
    public string Nombre { get; set; } = "";
    public string Categoria { get; set; } = "";
    public string Genero { get; set; } = "";
    public string Talla { get; set; } = "";
    public string Color { get; set; } = "";
    public decimal Precio { get; set; }
    public int Stock { get; set; }
    public string Marca { get; set; } = "";
    public string Material { get; set; } = "";
    public string Temporada { get; set; } = "";
    public decimal Descuento { get; set; }
    public string Imagen { get; set; } = "";
    public string Descripcion { get; set; } = "";
}

// ============================================================
// CONFIGURACIÓN
// ============================================================

var builder = WebApplication.CreateBuilder(args);

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseCors("AllowAll");

// ============================================================
// BASE DE DATOS TEMPORAL EN MEMORIA
// ============================================================

var ropas = new List<Ropa>
{
    new Ropa
    {
        Id = 1,
        Codigo = "POL001",
        Nombre = "Polo Básico",
        Categoria = "Polos",
        Genero = "Unisex",
        Talla = "M",
        Color = "Negro",
        Precio = 39.90m,
        Stock = 25,
        Marca = "Urban",
        Material = "Algodón",
        Temporada = "Verano",
        Descuento = 10,
        Imagen = "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab",
        Descripcion = "Polo básico de algodón"
    },

    new Ropa
    {
        Id = 2,
        Codigo = "POL002",
        Nombre = "Polo Blanco Clásico",
        Categoria = "Polos",
        Genero = "Hombre",
        Talla = "L",
        Color = "Blanco",
        Precio = 42.90m,
        Stock = 18,
        Marca = "Urban",
        Material = "Algodón",
        Temporada = "Verano",
        Descuento = 5,
        Imagen = "https://images.unsplash.com/photo-1583743814966-8936f37f4f7d",
        Descripcion = "Polo blanco de estilo clásico"
    },

    new Ropa
    {
        Id = 3,
        Codigo = "CAM001",
        Nombre = "Camisa Casual",
        Categoria = "Camisas",
        Genero = "Hombre",
        Talla = "M",
        Color = "Azul",
        Precio = 79.90m,
        Stock = 12,
        Marca = "Classic",
        Material = "Algodón",
        Temporada = "Otoño",
        Descuento = 15,
        Imagen = "https://images.unsplash.com/photo-1602810318383-e386cc2a3ccf",
        Descripcion = "Camisa casual de algodón"
    },

    new Ropa
    {
        Id = 4,
        Codigo = "CAM002",
        Nombre = "Camisa Formal",
        Categoria = "Camisas",
        Genero = "Hombre",
        Talla = "L",
        Color = "Blanco",
        Precio = 99.90m,
        Stock = 10,
        Marca = "Executive",
        Material = "Algodón",
        Temporada = "Todo el año",
        Descuento = 20,
        Imagen = "https://images.unsplash.com/photo-1598033129183-c4f50c736f10",
        Descripcion = "Camisa formal para ocasiones especiales"
    },

    new Ropa
    {
        Id = 5,
        Codigo = "PAN001",
        Nombre = "Jean Clásico",
        Categoria = "Pantalones",
        Genero = "Unisex",
        Talla = "32",
        Color = "Azul",
        Precio = 119.90m,
        Stock = 20,
        Marca = "Denim",
        Material = "Denim",
        Temporada = "Todo el año",
        Descuento = 10,
        Imagen = "https://images.unsplash.com/photo-1542272604-787c3835535d",
        Descripcion = "Jean clásico de corte regular"
    },

    new Ropa
    {
        Id = 6,
        Codigo = "PAN002",
        Nombre = "Jean Skinny",
        Categoria = "Pantalones",
        Genero = "Mujer",
        Talla = "28",
        Color = "Negro",
        Precio = 129.90m,
        Stock = 15,
        Marca = "Denim",
        Material = "Denim",
        Temporada = "Todo el año",
        Descuento = 15,
        Imagen = "https://images.unsplash.com/photo-1541099649105-f69ad21f3246",
        Descripcion = "Jean skinny de color negro"
    },

    new Ropa
    {
        Id = 7,
        Codigo = "VES001",
        Nombre = "Vestido Casual",
        Categoria = "Vestidos",
        Genero = "Mujer",
        Talla = "M",
        Color = "Rojo",
        Precio = 89.90m,
        Stock = 8,
        Marca = "Fashion",
        Material = "Poliéster",
        Temporada = "Verano",
        Descuento = 10,
        Imagen = "https://images.unsplash.com/photo-1595777457583-95e059d581b8",
        Descripcion = "Vestido casual para verano"
    },

    new Ropa
    {
        Id = 8,
        Codigo = "VES002",
        Nombre = "Vestido Elegante",
        Categoria = "Vestidos",
        Genero = "Mujer",
        Talla = "S",
        Color = "Negro",
        Precio = 159.90m,
        Stock = 6,
        Marca = "Elegance",
        Material = "Seda",
        Temporada = "Invierno",
        Descuento = 20,
        Imagen = "https://images.unsplash.com/photo-1566174053879-31528523f8ae",
        Descripcion = "Vestido elegante para eventos"
    },

    new Ropa
    {
        Id = 9,
        Codigo = "CAS001",
        Nombre = "Casaca Denim",
        Categoria = "Casacas",
        Genero = "Unisex",
        Talla = "M",
        Color = "Azul",
        Precio = 149.90m,
        Stock = 11,
        Marca = "Denim",
        Material = "Denim",
        Temporada = "Invierno",
        Descuento = 10,
        Imagen = "https://images.unsplash.com/photo-1576871337622-98d48d1cf531",
        Descripcion = "Casaca de denim clásica"
    },

    new Ropa
    {
        Id = 10,
        Codigo = "CAS002",
        Nombre = "Casaca Impermeable",
        Categoria = "Casacas",
        Genero = "Hombre",
        Talla = "L",
        Color = "Verde",
        Precio = 179.90m,
        Stock = 7,
        Marca = "Outdoor",
        Material = "Nylon",
        Temporada = "Invierno",
        Descuento = 15,
        Imagen = "https://images.unsplash.com/photo-1544966503-7cc5ac882d5f",
        Descripcion = "Casaca impermeable para exteriores"
    },

    new Ropa
    {
        Id = 11,
        Codigo = "ZAP001",
        Nombre = "Zapatillas Urbanas",
        Categoria = "Calzado",
        Genero = "Unisex",
        Talla = "42",
        Color = "Blanco",
        Precio = 199.90m,
        Stock = 14,
        Marca = "Urban Shoes",
        Material = "Sintético",
        Temporada = "Todo el año",
        Descuento = 10,
        Imagen = "https://images.unsplash.com/photo-1542291026-7eec264c27ff",
        Descripcion = "Zapatillas para uso diario"
    },

    new Ropa
    {
        Id = 12,
        Codigo = "ZAP002",
        Nombre = "Zapatillas Deportivas",
        Categoria = "Calzado",
        Genero = "Hombre",
        Talla = "43",
        Color = "Negro",
        Precio = 229.90m,
        Stock = 9,
        Marca = "Sport",
        Material = "Mesh",
        Temporada = "Todo el año",
        Descuento = 15,
        Imagen = "https://images.unsplash.com/photo-1549298916-b41d501d3772",
        Descripcion = "Zapatillas deportivas"
    },

    new Ropa
    {
        Id = 13,
        Codigo = "POL003",
        Nombre = "Polo Deportivo",
        Categoria = "Polos",
        Genero = "Hombre",
        Talla = "M",
        Color = "Gris",
        Precio = 49.90m,
        Stock = 21,
        Marca = "Sport",
        Material = "Dry Fit",
        Temporada = "Verano",
        Descuento = 5,
        Imagen = "https://images.unsplash.com/photo-1551488831-00ddcb6c6bd3",
        Descripcion = "Polo deportivo de secado rápido"
    },

    new Ropa
    {
        Id = 14,
        Codigo = "POL004",
        Nombre = "Polo Oversize",
        Categoria = "Polos",
        Genero = "Unisex",
        Talla = "XL",
        Color = "Beige",
        Precio = 59.90m,
        Stock = 17,
        Marca = "Street",
        Material = "Algodón",
        Temporada = "Verano",
        Descuento = 10,
        Imagen = "https://images.unsplash.com/photo-1503341504253-dff4815485f1",
        Descripcion = "Polo oversize de estilo urbano"
    },

    new Ropa
    {
        Id = 15,
        Codigo = "FAL001",
        Nombre = "Falda Casual",
        Categoria = "Faldas",
        Genero = "Mujer",
        Talla = "M",
        Color = "Negro",
        Precio = 69.90m,
        Stock = 13,
        Marca = "Fashion",
        Material = "Algodón",
        Temporada = "Verano",
        Descuento = 10,
        Imagen = "https://images.unsplash.com/photo-1583496661160-fb5886a0aaaa",
        Descripcion = "Falda casual de color negro"
    },

    new Ropa
    {
        Id = 16,
        Codigo = "FAL002",
        Nombre = "Falda Denim",
        Categoria = "Faldas",
        Genero = "Mujer",
        Talla = "S",
        Color = "Azul",
        Precio = 79.90m,
        Stock = 9,
        Marca = "Denim",
        Material = "Denim",
        Temporada = "Verano",
        Descuento = 5,
        Imagen = "https://images.unsplash.com/photo-1582142306909-195724d33ffc",
        Descripcion = "Falda denim juvenil"
    },

    new Ropa
    {
        Id = 17,
        Codigo = "BUZ001",
        Nombre = "Buzo Deportivo",
        Categoria = "Buzos",
        Genero = "Unisex",
        Talla = "L",
        Color = "Gris",
        Precio = 119.90m,
        Stock = 12,
        Marca = "Sport",
        Material = "Algodón",
        Temporada = "Invierno",
        Descuento = 10,
        Imagen = "https://images.unsplash.com/photo-1551488831-00ddcb6c6bd3",
        Descripcion = "Buzo deportivo cómodo"
    },

    new Ropa
    {
        Id = 18,
        Codigo = "BUZ002",
        Nombre = "Hoodie Urbano",
        Categoria = "Buzos",
        Genero = "Unisex",
        Talla = "XL",
        Color = "Negro",
        Precio = 139.90m,
        Stock = 16,
        Marca = "Street",
        Material = "Algodón",
        Temporada = "Invierno",
        Descuento = 15,
        Imagen = "https://images.unsplash.com/photo-1556821840-3a63f95609a7",
        Descripcion = "Hoodie urbano con capucha"
    },

    new Ropa
    {
        Id = 19,
        Codigo = "CHA001",
        Nombre = "Chompa de Lana",
        Categoria = "Chompas",
        Genero = "Mujer",
        Talla = "M",
        Color = "Beige",
        Precio = 109.90m,
        Stock = 8,
        Marca = "Winter",
        Material = "Lana",
        Temporada = "Invierno",
        Descuento = 20,
        Imagen = "https://images.unsplash.com/photo-1576566588028-4147f3842f27",
        Descripcion = "Chompa abrigadora de lana"
    },

    new Ropa
    {
        Id = 20,
        Codigo = "CHA002",
        Nombre = "Chompa Casual",
        Categoria = "Chompas",
        Genero = "Hombre",
        Talla = "L",
        Color = "Azul",
        Precio = 99.90m,
        Stock = 10,
        Marca = "Winter",
        Material = "Algodón",
        Temporada = "Invierno",
        Descuento = 10,
        Imagen = "https://images.unsplash.com/photo-1611312449412-6cefac5dc3e4",
        Descripcion = "Chompa casual para invierno"
    }
};

// ============================================================
// RUTA PRINCIPAL
// ============================================================

app.MapGet("/", () =>
{
    return Results.Ok(new
    {
        mensaje = "API TIENDA DE ROPA FUNCIONANDO",
        version = "2.0",
        estado = "OK",
        endpoints = new
        {
            listar = "GET /api/ropa",
            obtener = "GET /api/ropa/{id}",
            crear = "POST /api/ropa",
            actualizar = "PUT /api/ropa/{id}",
            eliminar = "DELETE /api/ropa/{id}"
        }
    });
});

// ============================================================
// GET - TODOS
// ============================================================

app.MapGet("/api/ropa", () =>
{
    return Results.Ok(ropas);
});

// ============================================================
// GET - POR ID
// ============================================================

app.MapGet("/api/ropa/{id:int}", (int id) =>
{
    var ropa = ropas.FirstOrDefault(x => x.Id == id);

    if (ropa == null)
    {
        return Results.NotFound(new
        {
            mensaje = $"No existe una prenda con ID {id}"
        });
    }

    return Results.Ok(ropa);
});

// ============================================================
// POST - CREAR
// ============================================================

app.MapPost("/api/ropa", (Ropa nuevaRopa) =>
{
    // Validaciones
    if (string.IsNullOrWhiteSpace(nuevaRopa.Codigo))
    {
        return Results.BadRequest(new
        {
            mensaje = "El código es obligatorio"
        });
    }

    if (string.IsNullOrWhiteSpace(nuevaRopa.Nombre))
    {
        return Results.BadRequest(new
        {
            mensaje = "El nombre es obligatorio"
        });
    }

    if (nuevaRopa.Precio < 0)
    {
        return Results.BadRequest(new
        {
            mensaje = "El precio no puede ser negativo"
        });
    }

    if (nuevaRopa.Stock < 0)
    {
        return Results.BadRequest(new
        {
            mensaje = "El stock no puede ser negativo"
        });
    }

    if (nuevaRopa.Descuento < 0 || nuevaRopa.Descuento > 100)
    {
        return Results.BadRequest(new
        {
            mensaje = "El descuento debe estar entre 0 y 100"
        });
    }

    // Generar ID automáticamente
    nuevaRopa.Id = ropas.Count == 0
        ? 1
        : ropas.Max(x => x.Id) + 1;

    ropas.Add(nuevaRopa);

    return Results.Created(
        $"/api/ropa/{nuevaRopa.Id}",
        nuevaRopa
    );
});

// ============================================================
// PUT - ACTUALIZAR
// ============================================================

app.MapPut("/api/ropa/{id:int}", (int id, Ropa datos) =>
{
    var ropa = ropas.FirstOrDefault(x => x.Id == id);

    if (ropa == null)
    {
        return Results.NotFound(new
        {
            mensaje = $"No existe una prenda con ID {id}"
        });
    }

    if (datos.Precio < 0)
    {
        return Results.BadRequest(new
        {
            mensaje = "El precio no puede ser negativo"
        });
    }

    if (datos.Stock < 0)
    {
        return Results.BadRequest(new
        {
            mensaje = "El stock no puede ser negativo"
        });
    }

    if (datos.Descuento < 0 || datos.Descuento > 100)
    {
        return Results.BadRequest(new
        {
            mensaje = "El descuento debe estar entre 0 y 100"
        });
    }

    // Mantener el ID original
    ropa.Codigo = datos.Codigo;
    ropa.Nombre = datos.Nombre;
    ropa.Categoria = datos.Categoria;
    ropa.Genero = datos.Genero;
    ropa.Talla = datos.Talla;
    ropa.Color = datos.Color;
    ropa.Precio = datos.Precio;
    ropa.Stock = datos.Stock;
    ropa.Marca = datos.Marca;
    ropa.Material = datos.Material;
    ropa.Temporada = datos.Temporada;
    ropa.Descuento = datos.Descuento;
    ropa.Imagen = datos.Imagen;
    ropa.Descripcion = datos.Descripcion;

    return Results.Ok(ropa);
});

// ============================================================
// DELETE - ELIMINAR
// ============================================================

app.MapDelete("/api/ropa/{id:int}", (int id) =>
{
    var ropa = ropas.FirstOrDefault(x => x.Id == id);

    if (ropa == null)
    {
        return Results.NotFound(new
        {
            mensaje = $"No existe una prenda con ID {id}"
        });
    }

    ropas.Remove(ropa);

    return Results.Ok(new
    {
        mensaje = $"Prenda con ID {id} eliminada correctamente",
        eliminado = ropa
    });
});

// ============================================================
// RUTA DE PRUEBA
// ============================================================

app.MapGet("/prueba/{id:int}", (int id) =>
{
    return Results.Ok(new
    {
        mensaje = "La ruta con parámetro funciona correctamente",
        id = id
    });
});

// ============================================================
// PUERTO RENDER
// ============================================================

var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";

app.Run($"http://0.0.0.0:{port}");
