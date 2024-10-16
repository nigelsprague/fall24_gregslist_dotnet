namespace gregslist_csharp.Controllers;

[ApiController, Route("api/[controller]")]
public class HousesController : ControllerBase
{
  private readonly HousesService _housesService;

  public HousesController(HousesService housesService)
  {
    _housesService = housesService;
  }
}