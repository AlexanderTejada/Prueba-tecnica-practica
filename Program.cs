using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Prueba_Tecnica;
using Prueba_Tecnica.Datos;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddNewtonsoftJson();

// Add Swagger/OpenAPI services.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddAutoMapper(typeof(MappingConfig));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    // Abrir navegador automáticamente
    var url = "https://localhost:7090/swagger";
    Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
