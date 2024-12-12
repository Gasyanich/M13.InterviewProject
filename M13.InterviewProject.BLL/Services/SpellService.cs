using M13.InterviewProject.BLL.Abstractions;

namespace M13.InterviewProject.BLL.Services;

public class SpellService(
    ISpellCheckIntegrationService spellCheckIntegrationService,
    ITextParser textParser) : ISpellService
{
    public async Task<int> GetSpellErrorsCount(string page, string scheme)
    {
        var innerText = await textParser.GetParsedText(page, scheme);

        var spellerErrors = await spellCheckIntegrationService.GetErrors(innerText);

        return spellerErrors.Count();
    }

    public async Task<IEnumerable<string>> GetSpellErrors(string page, string scheme, int wordsCount = 100)
    {
        var innerText = await textParser.GetParsedText(page, scheme);

        var spellerErrors = await spellCheckIntegrationService.GetErrors(innerText);

        // вопрос с магическим числом "100" в исходной версии. так задумано и нужно возвращать 100 слов с ошибками или должно гибко настраиваться:
        // сделал вместо 100 входной параметр wordsCount
        return spellerErrors.Take(wordsCount).Select(se => se.Word);
    }
}