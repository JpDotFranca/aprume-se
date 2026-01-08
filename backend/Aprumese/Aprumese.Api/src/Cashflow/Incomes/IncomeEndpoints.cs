namespace Aprumese.Api.src.Cashflow.Incomes;

static class IncomeEndpoints
{
    internal static void MapIncomeEndpoints(this IEndpointRouteBuilder endpointBuilder)
    {
        endpointBuilder.MapGet("", async (IncomeService incomeService) =>
        {
            Income newIncome = new Income("First one", 13.33m);

            await incomeService.Add(newIncome);
        });
    }
} 