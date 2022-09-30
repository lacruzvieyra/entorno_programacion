using ApiDespliegueContenedorAutor;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var Configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddControllers().AddJsonOptions(opciones =>
//    opciones.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
var conexion = Configuration.GetConnectionString("DefaultConnection");
var dbHost = Environment.GetEnvironmentVariable("DB_HOST");  //"ALEJANDRA\\HPSQL";
var dbName = Environment.GetEnvironmentVariable("DB_NAME"); //"ApidespliegueAutor";
var dbPassword = Environment.GetEnvironmentVariable("BD_SA_PASSWORD"); //"123456";
var con = $"Data Source={dbHost}; Initial Catalog={dbName}; User Id=sa; Password={dbPassword}";

builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(con));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
