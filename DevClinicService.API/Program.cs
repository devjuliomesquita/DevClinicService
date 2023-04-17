using DevClinicService.Application.Services.Implementations;
using DevClinicService.Application.Services.Interfaces;
using DevClinicService.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Chave de conecx�o
var conectionStrings = builder.Configuration.GetConnectionString("DataBase");

//Inje��o de deped�ncia
builder.Services.AddDbContext<DevClinicServiceContext>(options =>
    options.UseSqlServer(conectionStrings));

builder.Services.AddScoped<IServClinicService, ServClinicService>();
builder.Services.AddScoped<IUserService, UserService>();

//Inje��o de depend�ncia do padr�o repository

// Add services to the container.

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

app.MapControllers();

app.Run();
