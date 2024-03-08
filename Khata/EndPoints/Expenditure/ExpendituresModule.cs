using System.Reflection.Metadata;
using Carter;
using Khata.BLL.Services.IServices;
using Khata.BLL.ViewModel;
using Microsoft.AspNetCore.Cors;

namespace Khata.EndPoints.Expenditure
{
    public class ExpendituresModule : CarterModule
    {
        public ExpendituresModule()
            : base("api/expenditures/")
        {
        }
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/", async (IExpenditureServices _services) =>
            {
                var result = await _services.GetAllAsync();
                return Results.Ok(result);
            });

            app.MapPost("/", async (IExpenditureServices _services, ExpenditureDto dto) =>
            {
                var result = await _services.AddAsync(dto);
                return Results.Ok(result);
            });
            app.MapPatch("/", async (IExpenditureServices _services, ExpenditureDto dto) =>
            {
                var result = await _services.UpdateAsync(dto);
                return Results.Ok(result);  
            });
            app.MapGet("/{id:Guid}", async (Guid id, IExpenditureServices _services) =>
            {
                var result = await _services.GetByIdAsync(id);
                return Results.Ok(result);
            });
            app.MapDelete("/{id:Guid}", async (Guid id, IExpenditureServices _services) =>
            {
                var result = await _services.DeleteAsync(id);
                return Results.Ok(result);
            });
        }
    }
}
