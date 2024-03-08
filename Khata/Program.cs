using Carter;
using Khata.BLL;
using Khata.BLL.Services;
using Khata.BLL.Services.IServices;
using Khata.DAL.Persistance;
using Khata.DAL.Repository;
using Khata.DAL.Repository.IRepository;
using Khata.EndPoints.Expenditure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options => options
.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddCarter();
builder.Services.AddCors();
builder.Services.AddScoped<ExpendituresModule>();
builder.Services.AddAutoMapper(typeof(MapperProfile));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IExpenditureRepository, ExpenditureRepository>();
builder.Services.AddScoped<IExpenditureServices, ExpenditureServices>();

var app = builder.Build();

app.UseCors(options => 
options
.AllowAnyOrigin()
.AllowAnyHeader()
.AllowAnyMethod());


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapCarter();

app.Run();