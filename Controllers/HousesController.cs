using Microsoft.AspNetCore.Http.HttpResults;

namespace gregslist_csharp.Controllers;

[ApiController, Route("api/[controller]")]
public class HousesController : ControllerBase
{
  private readonly HousesService _housesService;
  public HousesController(HousesService housesService)
  {
    _housesService = housesService;
  }

  [HttpGet]
  public ActionResult<List<House>> GetAllHouses()
  {
    try
    {
      List<House> houses = _housesService.GetAllHouses();
      return Ok(houses);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }
}