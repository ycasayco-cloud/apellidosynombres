var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors();

app.MapGet("/", () =>
{
    return "API Tienda de Ropa funcionando";
});

app.MapGet("/api/ropa", () =>
{
    return Results.Ok(new[]
    {
        new
        {
            id = 1,
            codigo = "POL001",
            nombre = "Polo Básico Cuello Redondo",
            categoria = "Polos",
            genero = "Hombre",
            talla = "M",
            color = "Negro",
            precio = 39.90,
            stock = 25,
            marca = "Urban Style",
            material = "Algodón",
            temporada = "Todo el año",
            descuento = 0,
            imagen = "https://images.unsplash.com/photo-1521572163474-6864f9cf17ab?auto=format&fit=crop&w=800&q=80",
            descripcion = "Polo básico de algodón, ideal para uso diario."
        },
        new
        {
            id = 2,
            codigo = "POL002",
            nombre = "Polo Básico Blanco",
            categoria = "Polos",
            genero = "Hombre",
            talla = "L",
            color = "Blanco",
            precio = 39.90,
            stock = 18,
            marca = "Urban Style",
            material = "Algodón",
            temporada = "Todo el año",
            descuento = 10,
            imagen = "https://images.unsplash.com/photo-1583743814966-8936f37f3846?auto=format&fit=crop&w=800&q=80",
            descripcion = "Polo blanco de algodón con diseño clásico."
        },
        new
        {
            id = 3,
            codigo = "POL003",
            nombre = "Polo Oversize Negro",
            categoria = "Polos",
            genero = "Mujer",
            talla = "S",
            color = "Negro",
            precio = 49.90,
            stock = 12,
            marca = "Street Wear",
            material = "Algodón Premium",
            temporada = "Verano",
            descuento = 15,
            imagen = "https://images.unsplash.com/photo-1529139574466-a303027c1d8b?auto=format&fit=crop&w=800&q=80",
            descripcion = "Polo oversize de estilo urbano y moderno."
        },
        new
        {
            id = 4,
            codigo = "POL004",
            nombre = "Polo Deportivo Dry Fit",
            categoria = "Polos",
            genero = "Hombre",
            talla = "XL",
            color = "Azul",
            precio = 59.90,
            stock = 20,
            marca = "Sport Max",
            material = "Poliéster",
            temporada = "Todo el año",
            descuento = 5,
            imagen = "https://images.unsplash.com/photo-1579952363873-27f3bade9f55?auto=format&fit=crop&w=800&q=80",
            descripcion = "Polo deportivo ligero con tecnología de secado rápido."
        },
        new
        {
            id = 5,
            codigo = "CAM001",
            nombre = "Camisa Casual Manga Larga",
            categoria = "Camisas",
            genero = "Hombre",
            talla = "M",
            color = "Celeste",
            precio = 79.90,
            stock = 14,
            marca = "Classic Wear",
            material = "Algodón",
            temporada = "Primavera",
            descuento = 0,
            imagen = "https://images.unsplash.com/photo-1602810318383-e386cc2a3ccf?auto=format&fit=crop&w=800&q=80",
            descripcion = "Camisa casual de manga larga para ocasiones informales."
        },
        new
        {
            id = 6,
            codigo = "CAM002",
            nombre = "Camisa Formal Blanca",
            categoria = "Camisas",
            genero = "Hombre",
            talla = "L",
            color = "Blanco",
            precio = 99.90,
            stock = 10,
            marca = "Executive",
            material = "Algodón",
            temporada = "Todo el año",
            descuento = 10,
            imagen = "https://images.unsplash.com/photo-1598033129183-c4f50c736f10?auto=format&fit=crop&w=800&q=80",
            descripcion = "Camisa formal blanca ideal para oficina y eventos."
        },
        new
        {
            id = 7,
            codigo = "CAM003",
            nombre = "Camisa de Lino",
            categoria = "Camisas",
            genero = "Mujer",
            talla = "M",
            color = "Beige",
            precio = 109.90,
            stock = 8,
            marca = "Natural Fashion",
            material = "Lino",
            temporada = "Verano",
            descuento = 20,
            imagen = "https://images.unsplash.com/photo-1605763240000-7e93b172d754?auto=format&fit=crop&w=800&q=80",
            descripcion = "Camisa ligera de lino con estilo elegante."
        },
        new
        {
            id = 8,
            codigo = "PAN001",
            nombre = "Jean Clásico Azul",
            categoria = "Pantalones",
            genero = "Hombre",
            talla = "32",
            color = "Azul",
            precio = 119.90,
            stock = 16,
            marca = "Denim Pro",
            material = "Denim",
            temporada = "Todo el año",
            descuento = 0,
            imagen = "https://images.unsplash.com/photo-1542272604-787c3835535d?auto=format&fit=crop&w=800&q=80",
            descripcion = "Jean clásico de corte recto y color azul."
        },
        new
        {
            id = 9,
            codigo = "PAN002",
            nombre = "Jean Skinny Negro",
            categoria = "Pantalones",
            genero = "Mujer",
            talla = "28",
            color = "Negro",
            precio = 129.90,
            stock = 11,
            marca = "Denim Pro",
            material = "Denim Stretch",
            temporada = "Todo el año",
            descuento = 15,
            imagen = "https://images.unsplash.com/photo-1541099649105-f69ad21f3246?auto=format&fit=crop&w=800&q=80",
            descripcion = "Jean skinny con material stretch para mayor comodidad."
        },
        new
        {
            id = 10,
            codigo = "PAN003",
            nombre = "Pantalón Cargo Verde",
            categoria = "Pantalones",
            genero = "Hombre",
            talla = "34",
            color = "Verde Militar",
            precio = 139.90,
            stock = 7,
            marca = "Street Wear",
            material = "Algodón",
            temporada = "Otoño",
            descuento = 10,
            imagen = "https://images.unsplash.com/photo-1517445312882-bc9910d016b7?auto=format&fit=crop&w=800&q=80",
            descripcion = "Pantalón cargo con múltiples bolsillos."
        },
        new
        {
            id = 11,
            codigo = "PAN004",
            nombre = "Pantalón de Vestir",
            categoria = "Pantalones",
            genero = "Hombre",
            talla = "32",
            color = "Gris",
            precio = 149.90,
            stock = 9,
            marca = "Executive",
            material = "Poliéster",
            temporada = "Todo el año",
            descuento = 5,
            imagen = "https://images.unsplash.com/photo-1473966968600-fa801b869a1a?auto=format&fit=crop&w=800&q=80",
            descripcion = "Pantalón de vestir para oficina y eventos formales."
        },
        new
        {
            id = 12,
            codigo = "VES001",
            nombre = "Vestido Floral",
            categoria = "Vestidos",
            genero = "Mujer",
            talla = "S",
            color = "Rojo",
            precio = 129.90,
            stock = 13,
            marca = "Bella Moda",
            material = "Viscosa",
            temporada = "Primavera",
            descuento = 10,
            imagen = "https://images.unsplash.com/photo-1496747611176-843222e1e57c?auto=format&fit=crop&w=800&q=80",
            descripcion = "Vestido floral ligero y cómodo."
        },
        new
        {
            id = 13,
            codigo = "VES002",
            nombre = "Vestido Elegante Negro",
            categoria = "Vestidos",
            genero = "Mujer",
            talla = "M",
            color = "Negro",
            precio = 189.90,
            stock = 6,
            marca = "Bella Moda",
            material = "Poliéster",
            temporada = "Todo el año",
            descuento = 15,
            imagen = "https://images.unsplash.com/photo-1566174053879-31528523f8ae?auto=format&fit=crop&w=800&q=80",
            descripcion = "Vestido negro elegante para ocasiones especiales."
        },
        new
        {
            id = 14,
            codigo = "VES003",
            nombre = "Vestido Casual Corto",
            categoria = "Vestidos",
            genero = "Mujer",
            talla = "L",
            color = "Azul",
            precio = 99.90,
            stock = 15,
            marca = "Urban Style",
            material = "Algodón",
            temporada = "Verano",
            descuento = 5,
            imagen = "https://images.unsplash.com/photo-1515372039744-b8f02a3ae446?auto=format&fit=crop&w=800&q=80",
            descripcion = "Vestido casual corto para uso diario."
        },
        new
        {
            id = 15,
            codigo = "CHA001",
            nombre = "Casaca Denim",
            categoria = "Casacas",
            genero = "Hombre",
            talla = "L",
            color = "Azul",
            precio = 179.90,
            stock = 8,
            marca = "Denim Pro",
            material = "Denim",
            temporada = "Otoño",
            descuento = 10,
            imagen = "https://images.unsplash.com/photo-1578681994506-b8f463449011?auto=format&fit=crop&w=800&q=80",
            descripcion = "Casaca denim clásica para días frescos."
        },
        new
        {
            id = 16,
            codigo = "CHA002",
            nombre = "Casaca Impermeable",
            categoria = "Casacas",
            genero = "Hombre",
            talla = "M",
            color = "Negro",
            precio = 219.90,
            stock = 5,
            marca = "Adventure",
            material = "Nylon",
            temporada = "Invierno",
            descuento = 20,
            imagen = "https://images.unsplash.com/photo-1544966503-7cc5ac882d5f?auto=format&fit=crop&w=800&q=80",
            descripcion = "Casaca impermeable para actividades al aire libre."
        },
        new
        {
            id = 17,
            codigo = "CHA003",
            nombre = "Casaca de Cuero",
            categoria = "Casacas",
            genero = "Mujer",
            talla = "M",
            color = "Marrón",
            precio = 299.90,
            stock = 4,
            marca = "Premium Leather",
            material = "Cuero sintético",
            temporada = "Invierno",
            descuento = 10,
            imagen = "https://images.unsplash.com/photo-1551028719-00167b16eac5?auto=format&fit=crop&w=800&q=80",
            descripcion = "Casaca de estilo clásico con acabado tipo cuero."
        },
        new
        {
            id = 18,
            codigo = "ZAP001",
            nombre = "Zapatillas Urbanas",
            categoria = "Calzado",
            genero = "Hombre",
            talla = "42",
            color = "Blanco",
            precio = 159.90,
            stock = 10,
            marca = "Urban Shoes",
            material = "Sintético",
            temporada = "Todo el año",
            descuento = 5,
            imagen = "https://images.unsplash.com/photo-1542291026-7eec264c27ff?auto=format&fit=crop&w=800&q=80",
            descripcion = "Zapatillas urbanas cómodas para uso diario."
        },
        new
        {
            id = 19,
            codigo = "ZAP002",
            nombre = "Zapatillas Deportivas",
            categoria = "Calzado",
            genero = "Mujer",
            talla = "38",
            color = "Rosado",
            precio = 189.90,
            stock = 7,
            marca = "Sport Max",
            material = "Malla",
            temporada = "Todo el año",
            descuento = 15,
            imagen = "https://images.unsplash.com/photo-1552346154-21d32810aba3?auto=format&fit=crop&w=800&q=80",
            descripcion = "Zapatillas deportivas ligeras para entrenamiento."
        },
        new
        {
            id = 20,
            codigo = "ZAP003",
            nombre = "Botines de Cuero",
            categoria = "Calzado",
            genero = "Mujer",
            talla = "37",
            color = "Negro",
            precio = 249.90,
            stock = 5,
            marca = "Premium Leather",
            material = "Cuero sintético",
            temporada = "Invierno",
            descuento = 20,
            imagen = "https://images.unsplash.com/photo-1543163521-1bf539c55dd2?auto=format&fit=crop&w=800&q=80",
            descripcion = "Botines elegantes para combinar con diferentes estilos."
        },
        new
        {
            id = 21,
            codigo = "SUD001",
            nombre = "Hoodie Básico",
            categoria = "Sudaderas",
            genero = "Hombre",
            talla = "L",
            color = "Gris",
            precio = 119.90,
            stock = 17,
            marca = "Street Wear",
            material = "Algodón",
            temporada = "Invierno",
            descuento = 10,
            imagen = "https://images.unsplash.com/photo-1556821840-3a63f95609a7?auto=format&fit=crop&w=800&q=80",
            descripcion = "Hoodie cómodo con capucha y bolsillo frontal."
        },
        new
        {
            id = 22,
            codigo = "SUD002",
            nombre = "Hoodie Oversize",
            categoria = "Sudaderas",
            genero = "Mujer",
            talla = "M",
            color = "Lila",
            precio = 129.90,
            stock = 12,
            marca = "Urban Style",
            material = "Algodón",
            temporada = "Invierno",
            descuento = 15,
            imagen = "https://images.unsplash.com/photo-1620799140408-edc6dcb6d633?auto=format&fit=crop&w=800&q=80",
            descripcion = "Sudadera oversize de estilo juvenil."
        },
        new
        {
            id = 23,
            codigo = "FAL001",
            nombre = "Falda Plisada",
            categoria = "Faldas",
            genero = "Mujer",
            talla = "S",
            color = "Negro",
            precio = 89.90,
            stock = 10,
            marca = "Bella Moda",
            material = "Poliéster",
            temporada = "Primavera",
            descuento = 10,
            imagen = "https://images.unsplash.com/photo-1583496661160-fb5886a13d27?auto=format&fit=crop&w=800&q=80",
            descripcion = "Falda plisada de estilo elegante y juvenil."
        },
        new
        {
            id = 24,
            codigo = "FAL002",
            nombre = "Falda Denim",
            categoria = "Faldas",
            genero = "Mujer",
            talla = "M",
            color = "Azul",
            precio = 79.90,
            stock = 14,
            marca = "Denim Pro",
            material = "Denim",
            temporada = "Verano",
            descuento = 5,
            imagen = "https://images.unsplash.com/photo-1582142306909-195724d33ffc?auto=format&fit=crop&w=800&q=80",
            descripcion = "Falda denim corta para un look casual."
        },
        new
        {
            id = 25,
            codigo = "ACC001",
            nombre = "Gorra Urbana",
            categoria = "Accesorios",
            genero = "Unisex",
            talla = "Única",
            color = "Negro",
            precio = 39.90,
            stock = 30,
            marca = "Urban Style",
            material = "Algodón",
            temporada = "Todo el año",
            descuento = 0,
            imagen = "https://images.unsplash.com/photo-1521369909029-2afed882baee?auto=format&fit=crop&w=800&q=80",
            descripcion = "Gorra urbana ajustable."
        },
        new
        {
            id = 26,
            codigo = "ACC002",
            nombre = "Bufanda de Invierno",
            categoria = "Accesorios",
            genero = "Unisex",
            talla = "Única",
            color = "Gris",
            precio = 49.90,
            stock = 22,
            marca = "Winter Fashion",
            material = "Lana",
            temporada = "Invierno",
            descuento = 10,
            imagen = "https://images.unsplash.com/photo-1520903920243-00d872a2d1c9?auto=format&fit=crop&w=800&q=80",
            descripcion = "Bufanda abrigadora para temporada de frío."
        },
        new
        {
            id = 27,
            codigo = "ACC003",
            nombre = "Cinturón Clásico",
            categoria = "Accesorios",
            genero = "Hombre",
            talla = "M",
            color = "Marrón",
            precio = 59.90,
            stock = 18,
            marca = "Classic Wear",
            material = "Cuero sintético",
            temporada = "Todo el año",
            descuento = 5,
            imagen = "https://images.unsplash.com/photo-1624222247344-550fb60583dc?auto=format&fit=crop&w=800&q=80",
            descripcion = "Cinturón clásico para vestir o uso casual."
        },
        new
        {
            id = 28,
            codigo = "ACC004",
            nombre = "Cartera Casual",
            categoria = "Accesorios",
            genero = "Mujer",
            talla = "Única",
            color = "Beige",
            precio = 89.90,
            stock = 9,
            marca = "Bella Moda",
            material = "Cuero sintético",
            temporada = "Todo el año",
            descuento = 15,
            imagen = "https://images.unsplash.com/photo-1584917865442-de89df76afd3?auto=format&fit=crop&w=800&q=80",
            descripcion = "Cartera casual con varios compartimentos."
        },
        new
        {
            id = 29,
            codigo = "DEP001",
            nombre = "Short Deportivo",
            categoria = "Ropa deportiva",
            genero = "Hombre",
            talla = "M",
            color = "Negro",
            precio = 69.90,
            stock = 20,
            marca = "Sport Max",
            material = "Poliéster",
            temporada = "Verano",
            descuento = 10,
            imagen = "https://images.unsplash.com/photo-1591195853828-11db59a44f6b?auto=format&fit=crop&w=800&q=80",
            descripcion = "Short deportivo ligero para entrenamiento."
        },
        new
        {
            id = 30,
            codigo = "DEP002",
            nombre = "Leggings Deportivos",
            categoria = "Ropa deportiva",
            genero = "Mujer",
            talla = "S",
            color = "Negro",
            precio = 79.90,
            stock = 16,
            marca = "Sport Max",
            material = "Poliéster Stretch",
            temporada = "Todo el año",
            descuento = 15,
            imagen = "https://images.unsplash.com/photo-1506629905607-d9e0a5d0a8a5?auto=format&fit=crop&w=800&q=80",
            descripcion = "Leggings deportivos de alta elasticidad."
        },
        new
        {
            id = 31,
            codigo = "DEP003",
            nombre = "Polo Deportivo Mujer",
            categoria = "Ropa deportiva",
            genero = "Mujer",
            talla = "M",
            color = "Azul",
            precio = 64.90,
            stock = 19,
            marca = "Sport Max",
            material = "Dry Fit",
            temporada = "Todo el año",
            descuento = 5,
            imagen = "https://images.unsplash.com/photo-1518611012118-696072aa579a?auto=format&fit=crop&w=800&q=80",
            descripcion = "Polo deportivo transpirable para entrenamiento."
        },
        new
        {
            id = 32,
            codigo = "DEP004",
            nombre = "Buzo Deportivo",
            categoria = "Ropa deportiva",
            genero = "Unisex",
            talla = "L",
            color = "Gris",
            precio = 149.90,
            stock = 8,
            marca = "Sport Max",
            material = "Algodón",
            temporada = "Invierno",
            descuento = 20,
            imagen = "https://images.unsplash.com/photo-1556906781-9a412961c28c?auto=format&fit=crop&w=800&q=80",
            descripcion = "Buzo deportivo completo para entrenamiento y uso casual."
        }
    });
});

var port = Environment.GetEnvironmentVariable("Port") ?? "10000";

app.Run($"http://0.0.0.0:{port}");
