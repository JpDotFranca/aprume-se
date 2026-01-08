using Aprumese.Api.src.Cashflow.Incomes.Models;

namespace Aprumese.Api.src.Cashflow.Incomes;

class IncomeService(IncomeRepository IncomeRepository)
{
    internal async Task<Income> Add(Income income)
        => await IncomeRepository.Add(income);
}
