using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CareerConsole.Data.SQLite;

/// <summary>
/// Factory class for creating and initializing an instance of <see cref="CareerConsoleDb"/> using SQLite.
/// Encapsulates database creation logic to ensure a structured setup.
/// </summary>
public static class SqLiteDatabaseFactory
{
    /// <summary>
    /// Creates and initializes a new instance of <see cref="CareerConsoleDb"/> with a SQLite database connection.
    /// Ensures the database is created if it does not exist.
    /// </summary>
    /// <returns>A configured <see cref="CareerConsoleDb"/> instance.</returns>
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