namespace Aprumese.Api.src.Cashflow.Incomes.Models;

internal class IncomeResponse
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public decimal Value { get; set; }
    public int? CategoryId { get; set; }
}