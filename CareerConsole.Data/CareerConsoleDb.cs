using Microsoft.EntityFrameworkCore;

namespace CareerConsole.Data;

/// <summary>
/// Represents the main database context for the application.
/// </summary>
public class CareerConsoleDb : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CareerConsoleDb"/> class.
    /// </summary>
    /// <param name="options">The database options for EF Core.</param>
    public CareerConsoleDb(DbContextOptions<CareerConsoleDb> options) : base(options) { }

}