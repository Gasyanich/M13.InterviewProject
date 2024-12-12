using M13.InterviewProject.BLL.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace M13.InterviewProject.Controllers;

[ApiController]
[Route("api/[controller]/errors")]
public class SpellController(ISpellService spellService) : ControllerBase
{
    /// <summary>
    ///     Проверить текст страницы по заданному адресу и получить список слов с ошибками
    /// </summary>
    [HttpGet]
    public async Task<IEnumerable<string>> SpellErrors(string page, string scheme)
    {
        var spellErrors = await spellService.GetSpellErrors(page, scheme);

        return spellErrors;
    }

    /// <summary>
    ///     Проверить текст страницы по заданному адресу и получить количество слов с ошибками
    /// </summary>
    [HttpGet("count")]
    public async Task<int> SpellErrorsCount(string page, string scheme)
    {
        var spellErrorsCount = await spellService.GetSpellErrorsCount(page, scheme);

        return spellErrorsCount;
    }
}