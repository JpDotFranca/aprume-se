using Aprumese.Api.src.Shared.Repository;

namespace Aprumese.Api.src.Cashflow.Incomes;

public class IncomeRepository(DatabaseContext DatabaseContext)
{
    public async Task<Income> Add(Income newIncome)
    {
        DatabaseContext.Add(newIncome);

        await DatabaseContext.SaveChangesAsync();

        return newIncome;
    }
}
