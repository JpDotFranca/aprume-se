using Aprumese.Api.src.Cashflow.Incomes;
using Aprumese.Api.src.Shared.Repository;
using Asp.Versioning;
using Asp.Versioning.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiVersioning(options =>
{
    options.ReportApiVersions = true;
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
}).AddApiExplorer(options =>
{
    options.GroupNameFormat = "'v'V";
    options.SubstituteApiVersionInUrl = true;
});

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddTransient<IncomeRepository>();
builder.Services.AddTransient<IncomeService>();

WebApplication app = builder.Build();

ApiVersionSet apiVersionSet = app.NewApiVersionSet()
                                 .HasApiVersion(new ApiVersion(1)) 
                                 .ReportApiVersions()
                                 .Build();

RouteGroupBuilder versionedGroup = app.MapGroup("api/v{version:apiVersion}")
                                      .WithApiVersionSet(apiVersionSet);

versionedGroup.MapIncomeEndpoints();

app.Run();
