namespace M13.InterviewProject.BLL.Abstractions;

public interface ISpellService
{
    /// <summary>
    ///     Получить слова с ошибками на странице
    /// </summary>
    /// <param name="page">Страница</param>
    /// <param name="scheme">Схема http/https</param>
    /// <param name="wordsCount">Ограничить количество слов</param>
    /// <returns>Слова с ошибками</returns>
    Task<IEnumerable<string>> GetSpellErrors(string page, string scheme, int wordsCount = 100);

    /// <summary>
    ///     Получить количество слов с ошибками на странице
    /// </summary>
    /// <param name="page">Страница</param>
    /// <param name="scheme">Схема http/https</param>
    /// <returns>Количество слов с ошибками</returns>
    Task<int> GetSpellErrorsCount(string page, string scheme);
}