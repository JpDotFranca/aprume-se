using Aprumese.Api.src.Cashflow.Incomes.Models;
using Aprumese.Api.src.Shared.Repository;

namespace Aprumese.Api.src.Cashflow.Incomes;

class IncomeRepository(DatabaseContext DatabaseContext)
{
    internal async Task<Income> Add(Income newIncome)
    {
        DatabaseContext.Add(newIncome);

        await DatabaseContext.SaveChangesAsync();

        return newIncome;
    }
}
