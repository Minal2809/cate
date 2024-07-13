using category.Entities;
using Microsoft.EntityFrameworkCore;

namespace category.CatData;

public class Setcat(DbContextOptions options) : DbContext(options)
{
  public DbSet<CatEntity> Cat_Table { get; set; }

}

