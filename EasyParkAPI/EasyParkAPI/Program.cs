using System.Text.Json.Serialization;
using EasyParkAPI.Infrastructure;
using EasyParkAPI.Services.Carro;
using EasyParkAPI.Services.Reserva;
using EasyParkAPI.Services.Usuario;
using EasyParkAPI.Services.Vaga;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<ICarroService, CarroService>();
builder.Services.AddScoped<IVagaService, VagaService>();
builder.Services.AddScoped<IReservaService, ReservaService>();

builder.Services.AddDbContext<ConnectionContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
