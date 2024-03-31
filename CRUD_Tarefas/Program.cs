using CRUD_Tarefas.Configurations;
using Domain.Interfaces.Datas;
using Domain.Interfaces.Services;
using Infrastructure.Data.Repository;
using Service.Mapper;
using Service.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(ListaTarefaMapper).GetTypeInfo().Assembly);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEntityFramework(builder.Configuration);

//Inject Services
builder.Services.AddScoped<IListaTarefaService, ListaTarefaService>();

//Inject Repositories
builder.Services.AddScoped<IListaTarefaRepository, ListaTarefaRepository>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();