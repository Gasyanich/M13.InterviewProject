using M13.InterviewProject.BLL.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace M13.InterviewProject.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RulesController(IRulesRepository rulesRepository) : Controller
{
    /// <summary>
    ///     Добавить правило к сайту
    /// </summary>
    [HttpPost]
    public IActionResult Add(string site, string rule)
    {
        rulesRepository.Add(site, rule);

        return NoContent();
    }

    /// <summary>
    ///     Получить правило к сайту
    /// </summary>
    [HttpGet("{site}")]
    public IActionResult Get(string site)
    {
        var rule = rulesRepository.Get(site);

        if (rule is null)
            return NotFound();

        return Ok(rule);
    }

    /// <summary>
    ///     Удалить правило к сайту
    /// </summary>
    [HttpDelete("delete")]
    public IActionResult Delete(string site)
    {
        rulesRepository.Delete(site);

        return NoContent();
    }
}