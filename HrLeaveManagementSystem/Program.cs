using HrLeaveManagementSystem.Src.Core.Application;
using HrLeaveManagementSystem.Src.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddApplicationServices();

builder.Services.AddCors(options => options.AddPolicy("all", builder => builder.AllowAnyOrigin().AllowAnyHeader()));

app.Run();
