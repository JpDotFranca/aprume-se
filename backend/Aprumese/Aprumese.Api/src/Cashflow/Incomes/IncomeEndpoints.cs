namespace Aprumese.Api.src.Cashflow.Incomes;

static class IncomeEndpoints
{
    private const string RESOURCE_ROUTER = "Incomes";

    internal static void MapIncomeEndpoints(this IEndpointRouteBuilder endpointBuilder)
    {
        endpointBuilder.MapPost($"/{RESOURCE_ROUTER}", async (IncomeService incomeService) =>
        {
            Income newIncome = new Income("First one", 13.33m);

            return await incomeService.Add(newIncome);
        });
    }
}