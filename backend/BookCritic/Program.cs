using BC.BLL.MappingProfiles;
using BC.BLL.Services;
using BC.Common.DTO.Book;
using BC.DAL.Context;
using BookCritic.Validators;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<BookService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BookCriticContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:BookCritic"]);
});

builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<BookProfile>();
},
Assembly.GetExecutingAssembly());

builder.Services.AddSingleton<IValidator<NewBookDTO>, NewBookDTOValidator>();

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
