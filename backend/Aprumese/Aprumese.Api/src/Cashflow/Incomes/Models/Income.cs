using Aprumese.Api.src.Shared.Domain;

namespace Aprumese.Api.src.Cashflow.Incomes.Models;

public class Income : Entity
{
    public override int Id { get; set; }
    public string Description { get; init; }
    public decimal Value { get; init; }
    public IncomeCategory? Category { get; init; }

    public Income(string description, decimal value)
    {
        Description = description;
        Value = value;
        Category = default;
    }

    internal IncomeResponse MapToIncomeResponse()
        => new IncomeResponse()
        {
            Id = this.Id,
            CategoryId = this.Category?.Id,
            Description = this.Description,
            Value = this.Value
        };
}
