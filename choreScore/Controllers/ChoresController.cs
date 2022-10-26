namespace chore_score.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChoresController : ControllerBase
{
  private readonly ChoresService _cs;

  [HttpGet]
  public ActionResult<List<Chore>> Get()
  {
    try
    {
      var chores = _cs.GetChores();
      return Ok(chores);
    }
    catch (System.Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  public ChoresController(ChoresService cs)
  {
    _cs = cs;
  }
}