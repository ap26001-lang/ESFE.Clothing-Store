using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// 1. Agregar servicios para Controladores con Vistas (MVC)
builder.Services.AddControllersWithViews();

// 2. Configurar la Autenticación basada en Cookies
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Home/Index";
        options.AccessDeniedPath = "/Home/Index";
        options.ExpireTimeSpan = TimeSpan.FromHours(8); // Duración de la sesión
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

// 3. Middlewares de Seguridad (IMPORTANTE: El orden debe ser Authentication y luego Authorization)
app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

// 4. Configuración de la Ruta por Defecto (Redirige a Home/Index)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
