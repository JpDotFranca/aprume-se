using Aprumese.Api.src.Cashflow.Incomes.Models;

namespace Aprumese.Api.src.Cashflow.Incomes;

static class IncomeEndpoints
{
    private const string RESOURCE_ROUTER = "Incomes";

    internal static void MapIncomeEndpoints(this IEndpointRouteBuilder endpointBuilder)
    {
        endpointBuilder.MapPost($"/{RESOURCE_ROUTER}", async (IncomeRequest incomeRequest, IncomeService incomeService) =>
        {
            Income newIncome = new Income("First one", 13.33m);

            await incomeService.Add(newIncome);

            IncomeResponse incomeResponse = newIncome.MapToIncomeResponse();

            return incomeResponse;
        });
    }
}