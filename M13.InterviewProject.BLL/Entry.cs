using System.Net;
using M13.InterviewProject.BLL.Abstractions;
using M13.InterviewProject.BLL.Services;
using Microsoft.Extensions.DependencyInjection;

namespace M13.InterviewProject.BLL;

public static class Entry
{
    public static IServiceCollection AddBll(this IServiceCollection services)
    {
        services.AddScoped<ISpellService, SpellService>();
        
        services.AddScoped<ITextParser, TextParser>();
        services.AddHttpClient<ITextParser, TextParser>()
            .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
        {
            AllowAutoRedirect = true,
            AutomaticDecompression = DecompressionMethods.Deflate
        });
        
        return services;
    }
}