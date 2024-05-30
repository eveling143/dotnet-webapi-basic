using Microsoft.EntityFrameworkCore;
using MyVaccine.WebApi.Literals;
using MyVaccine.WebApi.Models;

namespace MyVaccine.WebApi.Configurations;

public static class DbConfigurations
{
    public static IServiceCollection SetDatabaseConfiguration(this IServiceCollection services)
    {
        //var connectionString = Environment.GetEnvironmentVariable(MyVaccineLiterals.CONNECTION_STRING);
        var connectionString = "Server=localhost,38792;Database=MyVaccineAppDb;User Id=sa;Password=Your_password123;TrustServerCertificate=True;";
        services.AddDbContext<MyVaccineAppDbContext>(options =>
                    options.UseSqlServer(
                                connectionString
                                )
                    );
        return services;
    }
}