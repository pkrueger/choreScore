namespace choreScore.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChoresController : ControllerBase
{
  private readonly ChoresService _cs;
  private readonly Auth0Provider _a0p;
  public ChoresController(ChoresService cs, Auth0Provider a0p)
  {
    _cs = cs;
    _a0p = a0p;
  }

  [HttpGet]
  [Authorize]
  public async Task<ActionResult<List<Chore>>> Get()
  {
    try
    {
      var userInfo = await _a0p.GetUserInfoAsync<Account>(HttpContext);
      var chores = _cs.GetChoresByCreatorId(userInfo?.Id);
      return Ok(chores);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}