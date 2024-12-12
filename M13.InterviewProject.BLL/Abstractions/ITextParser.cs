namespace M13.InterviewProject.BLL.Abstractions;

public interface ITextParser
{
    /// <summary>
    /// Спарсить текст по правилу <see cref="rule"/> если оно задано
    /// Если <see cref="rule"/> не задано, использовать <see cref="page"/> для поиска сохраненного правила для сайта
    /// </summary>
    /// <param name="page">Страница</param>
    /// <param name="scheme">Схема http/https</param>
    /// <param name="rule">Правило</param>
    Task<string> GetParsedText(string page, string scheme, string? rule = null);
}