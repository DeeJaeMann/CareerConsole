using Microsoft.EntityFrameworkCore;

namespace CareerConsole.Data;

public class CareerConsoleDb : DbContext
{
    public CareerConsoleDb(DbContextOptions<CareerConsoleDb> options) : base(options) { }

}