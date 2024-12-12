using M13.InterviewProject.BLL.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace M13.InterviewProject.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ParseTextController(ITextParser textParser) : ControllerBase
{
    /// <summary>
    ///     Проверить, как парсится страница по правилу
    /// </summary>
    [HttpGet]
    public async Task<string> Test(string page, string scheme, string? rule = null)
    {
        var parsedText = await textParser.GetParsedText(page, scheme, rule);

        return parsedText;
    }
}