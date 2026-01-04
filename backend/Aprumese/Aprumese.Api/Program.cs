using Aprumese.Api.src.Cashflow.Incomes;
using Aprumese.Api.src.Shared.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddTransient<IncomeRepository>();

WebApplication app = builder.Build();

app.Map("/", async (IncomeRepository incomeRepository) =>
{
    Income newIncome = new Income("First one", 13.33m);
    await incomeRepository.Add(newIncome);
});

app.Run();
