namespace M13.InterviewProject.BLL.Abstractions;

public interface IRulesRepository
{
    /// <summary>
    /// Получить правило для сайта
    /// </summary>
    /// <param name="site">Сайт</param>
    public string? Get(string site);
    
    /// <summary>
    /// Добавить правило для сайта
    /// </summary>
    /// <param name="site">Сайт</param>
    /// <param name="rule">Правило</param>
    void Add(string site, string rule);
    
    /// <summary>
    /// Удалить правило для сайта
    /// </summary>
    /// <param name="site">Сайт</param>
    void Delete(string site);
    
}