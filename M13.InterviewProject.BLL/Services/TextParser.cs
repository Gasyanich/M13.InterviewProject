using System.Text;
using HtmlAgilityPack;
using M13.InterviewProject.BLL.Abstractions;

namespace M13.InterviewProject.BLL.Services;

public class TextParser(HttpClient httpClient, IRulesRepository rulesRepository) : ITextParser
{
    public async Task<string> GetParsedText(string page, string scheme, string? rule = null)
    {
        var uriBuilder = new UriBuilder
        {
            Scheme = scheme,
            Host = page
        };
        
        var site = uriBuilder.Host;

        var response = await httpClient.GetAsync(uriBuilder.Uri);
        var responseHtml = await response.Content.ReadAsStringAsync();
            
        var document = new HtmlDocument();
        document.LoadHtml(responseHtml);

        // если не нашли правило и в метод пришел null кидать условный RuleNotFoundException()
         rule ??= rulesRepository.Get(site);
        
        var innerTextSb = new StringBuilder();
        foreach (var node in document.DocumentNode.SelectNodes(rule))
            innerTextSb.Append("\r\n" + node.InnerText);
                
        return innerTextSb.ToString();
    }
}