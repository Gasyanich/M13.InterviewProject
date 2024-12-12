using System.Collections.Concurrent;
using M13.InterviewProject.BLL.Abstractions;

namespace M13.InterviewProject.DAL.Repositories;

public class RulesRepository : IRulesRepository
{
    private readonly ConcurrentDictionary<string, string> _rules = new();

    public void Add(string site, string rule)
    {
        _rules.TryAdd(site, rule);
    }
    
    public string? Get(string site)
    {
        return _rules.GetValueOrDefault(site);
    }

    public void Delete(string site)
    {
        _rules.TryRemove(site, out _);
    }
}