using Microsoft.EntityFrameworkCore;
using TshirtChallenge.API.DependencyInjection.Application;
using TshirtChallenge.API.DependencyInjection.Repository;
using TshirtChallenge.Infra.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MainContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

new Repositories().AddRepositoriesDependencyInjection(builder.Services);
new Services().AddServicesDependencyInjection(builder.Services);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
