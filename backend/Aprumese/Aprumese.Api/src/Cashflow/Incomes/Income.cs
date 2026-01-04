using Aprumese.Api.src.Shared.Domain;

namespace Aprumese.Api.src.Cashflow.Incomes;

public class Income : Entity
{
    public override int Id { get; set; }
    public  string Description { get; init; }
    public  decimal Value { get; init; }
    public  IncomeCategory? Category { get; init; }

    public Income(string description, decimal value)
    {
        Description = description;
        Value = value;
        Category = default;
    }

    public Income(string description, decimal value, IncomeCategory incomeCategory)
    {

    }
}
