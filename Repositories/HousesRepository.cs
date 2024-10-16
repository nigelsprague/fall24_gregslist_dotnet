

namespace gregslist_csharp.Repositories;

public class HousesRepository
{
  private readonly IDbConnection _db;
  public HousesRepository(IDbConnection db)
  {
    _db = db;
  }

  internal House CreateHouse(House houseData)
  {
    string sql = @"
      INSERT INTO
      houses(sqft, bedrooms, bathrooms, imgUrl, description, price, creatorId)
      VALUES(@Sqft, @Bedrooms, @Bathrooms, @ImgUrl, @Description, @Price, @CreatorId);
      
      SELECT * FROM houses WHERE id = LAST_INSERT_ID();";

    House house = _db.Query<House>(sql, houseData).FirstOrDefault();
    return house;
  }

  internal List<House> GetAllHouses()
  {
    string sql = @"
      SELECT
      houses.*,
      accounts.*
      FROM houses
      JOIN accounts ON houses.creatorId = accounts.id;";

    List<House> houses = _db.Query<House, Account, House>(sql, (house, account) =>
    {
      house.Creator = account;
      return house;
    }).ToList();
    return houses;
  }
}