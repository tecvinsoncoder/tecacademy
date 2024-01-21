using FluentValidation;
using Microsoft.EntityFrameworkCore;
using TecAcademy.Core.Interfaces;
using TecAcademy.Repositories.Data;
using TecAcademy.Repositories.Implementations;
using TecAcademy.Services.Contracts.Institutions;
using TecAcademy.Services.Implemetations;
using TecAcademy.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AcademyContext>(options =>
    options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]));

builder.Services.AddScoped<IInstitutionRepository, InstitutionRepository>();
builder.Services.AddScoped<IInstitutionService, InstitutionService>();

builder.Services.AddScoped<IValidator<InstitutionCreateReq>, InstitutionCreateReqValidator>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
