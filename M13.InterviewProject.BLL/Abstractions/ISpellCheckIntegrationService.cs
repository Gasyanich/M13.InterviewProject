using M13.InterviewProject.BLL.Models;

namespace M13.InterviewProject.BLL.Abstractions;

/// <summary>
///     Cервис  для поиска орфографических ошибок в тексте
/// </summary>
public interface ISpellCheckIntegrationService
{
    /// <summary>
    ///     Получить список слов, в которых допущены ошибки
    /// </summary>
    /// <param name="text">Текст для проверки</param>
    /// <returns>Список слов, в которых допущены ошибки</returns>
    Task<IEnumerable<SpellerErrors>> GetErrors(string text);
}