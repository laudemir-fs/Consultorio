using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TooltipsController : ControllerBase
{
    private readonly ITooltipsRepository _tooltipsRepository;

    public TooltipsController(ITooltipsRepository tooltipsRepository)
    {
        _tooltipsRepository = tooltipsRepository;
    }

    [HttpGet]
    public ActionResult GetAllTooltips()
    {
            var tooltips =  _tooltipsRepository.ListAll();
            return Ok(tooltips);
    }
}