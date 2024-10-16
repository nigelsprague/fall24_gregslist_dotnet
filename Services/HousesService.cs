namespace gregslist_csharp.Services;

public class HousesService
{
  private readonly HousesRepository _repository;
  public HousesService(HousesRepository repository)
  {
    _repository = repository;
  }
}