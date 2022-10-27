namespace choreScore.Controllers;

[ApiController]
[Authorize]
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
  public async Task<ActionResult<List<Chore>>> GetChores()
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

  [HttpGet("{id}")]
  public async Task<ActionResult<Chore>> GetChore(int id)
  {
    try
    {
      var userInfo = await _a0p.GetUserInfoAsync<Account>(HttpContext);
      Chore chore = _cs.GetChoreById(id, userInfo?.Id);
      return Ok(chore);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  public async Task<ActionResult<Chore>> CreateChore([FromBody] Chore choreData)
  {
    try
    {
      var userInfo = await _a0p.GetUserInfoAsync<Account>(HttpContext);
      choreData.creatorId = userInfo?.Id;
      Chore chore = _cs.CreateChore(choreData);
      return Ok(chore);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}