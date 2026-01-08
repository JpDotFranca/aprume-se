namespace Aprumese.Api.src.Cashflow.Incomes.Models;

internal sealed class IncomeRequest
{ 
    public string? Description { get; set; }
    public decimal Value { get; set; }
    public int? CategoryId { get; set; }
}