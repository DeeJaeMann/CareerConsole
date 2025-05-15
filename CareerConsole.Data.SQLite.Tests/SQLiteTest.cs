using System.ComponentModel;

namespace CareerConsole.Data.SQLite.Tests;

public class SqLiteTest
{
    [Fact]
    [Category("SQLite")]
    [Description("This tests that Create() does not throw an exception")]
    public void NoExceptionTest()
    {
        using CareerConsoleDb dbContext = SqLiteDatabaseFactory.Create();
        Exception ex = Record.Exception(() => dbContext.Database.EnsureCreated());
        
        Assert.Null(ex);
    }
    
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
