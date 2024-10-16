
using Microsoft.AspNetCore.Http.HttpResults;

namespace gregslist_csharp.Services;

public class HousesService
{
  private readonly HousesRepository _repository;
  public HousesService(HousesRepository repository)
  {
    _repository = repository;
  }

  internal List<House> GetAllHouses()
  {
    List<House> houses = _repository.GetAllHouses();
    return houses;
  }
}