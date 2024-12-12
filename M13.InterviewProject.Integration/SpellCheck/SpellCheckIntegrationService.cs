using System.Net;
using System.Net.Http.Json;
using M13.InterviewProject.BLL.Abstractions;
using M13.InterviewProject.BLL.Models;

namespace M13.InterviewProject.Integration.SpellCheck;

public class SpellCheckIntegrationService(HttpClient httpClient) : ISpellCheckIntegrationService
{
    public async Task<IEnumerable<SpellerErrors>> GetErrors(string text)
    {
        var urlEncodeText = WebUtility.UrlEncode(text);
        
        var response = await httpClient.GetAsync("services/spellservice.json/checkText?text=" + urlEncodeText);

        var spellerErrorsArray = await response.Content.ReadFromJsonAsync<IEnumerable<SpellerErrors>>();

        return spellerErrorsArray!;
    }
}