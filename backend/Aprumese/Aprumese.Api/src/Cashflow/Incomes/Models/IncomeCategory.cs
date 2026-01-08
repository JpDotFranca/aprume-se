using Aprumese.Api.src.Shared.Domain;

namespace Aprumese.Api.src.Cashflow.Incomes.Models;

public class IncomeCategory : Entity
{
    public override int Id { get; set; }
    public  string Description { get; set; }

    public IncomeCategory(int id, string description)
    {
        Id = id;
        Description = description;
    }

    public IncomeCategory(string description)
    {
        Description = description;
    }
}
