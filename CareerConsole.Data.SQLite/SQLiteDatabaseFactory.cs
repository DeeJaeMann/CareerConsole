using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CareerConsole.Data.SQLite;

public static class SqLiteDatabaseFactory
{
    public static CareerConsoleDb Create()
    {
        string databaseFile = "CareerConsole.db";
        string path = Path.Combine(Environment.CurrentDirectory, databaseFile);
        string connectionString = $"Data Source={path}";
        DbContextOptions<CareerConsoleDb> optionsBuilder = new DbContextOptionsBuilder<CareerConsoleDb>()
            .UseSqlite(connectionString)
            .Options;

        CareerConsoleDb dbContext = new(optionsBuilder);
        dbContext.Database.EnsureCreated();
        return dbContext;
    }
}