namespace gregslist_csharp.Repositories;

public class HousesRepository
{
  private readonly IDbConnection _db;
  public HousesRepository(IDbConnection db)
  {
    _db = db;
  }
}