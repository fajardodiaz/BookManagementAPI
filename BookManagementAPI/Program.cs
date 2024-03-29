using BookManagementAPI.Configurations;
using BookManagementAPI.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Database Connection
var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

// Adding CORS Configuration
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
});
builder.Host.UseSerilog((ctx, lc) => lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration));

// Adding AutoMapper
builder.Services.AddAutoMapper(typeof(MapperConfig));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("AllowAll");

app.UseSerilogRequestLogging();

app.MapControllers();

app.Run();
