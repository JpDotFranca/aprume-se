using Aprumese.Api.src.Cashflow.Incomes;
using Microsoft.EntityFrameworkCore;

namespace Aprumese.Api.src.Shared.Repository;

public class DatabaseContext(DbContextOptions<DatabaseContext> Options)
    : DbContext(Options)
{
    public DbSet<Income> Incomes { get; set; }
}
