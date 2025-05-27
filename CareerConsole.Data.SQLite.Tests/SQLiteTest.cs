using System.ComponentModel;

namespace CareerConsole.Data.SQLite.Tests;

/// <summary>
/// Unit tests for the <see cref="SqLiteDatabaseFactory"/> class.
/// Verifies database creation behavior and ensures the <see cref="CareerConsoleDb"/> instance is valid.
/// </summary>
public class SqLiteTest
{
    /// <summary>
    /// Tests that <see cref="SqLiteDatabaseFactory.Create"/> does not throw an exception when ensuring the database is created.
    /// </summary>
    [Fact]
    [Category("SQLite")]
    [Description("This tests that Create() does not throw an exception")]
    public void NoExceptionTest()
    {
        using CareerConsoleDb dbContext = SqLiteDatabaseFactory.Create();
        Exception ex = Record.Exception(() => dbContext.Database.EnsureCreated());
        
        Assert.Null(ex);
    }
    
    /// <summary>
    /// Tests that <see cref="SqLiteDatabaseFactory.Create"/> correctly returns a valid <see cref="CareerConsoleDb"/> instance.
    /// </summary>
    [Fact]
    [Category("SQLite")]
    [Description("This tests that Create() returns a valid DbContext")]
    public void DbContextCreateTest()
    {
        using CareerConsoleDb dbContext = SqLiteDatabaseFactory.Create();

        Assert.NotNull(dbContext);
        Assert.IsType<CareerConsoleDb>(dbContext);
    }
}
