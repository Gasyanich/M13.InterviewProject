using M13.InterviewProject.BLL.Abstractions;
using M13.InterviewProject.Integration.SpellCheck;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace M13.InterviewProject.Integration;

public static class Entry
{
    public static IServiceCollection AddIntegration(this IServiceCollection services, IConfiguration configuration)
    {
        var spellCheckApiOptions = configuration.GetSection(nameof(SpellCheckApiOptions)).Get<SpellCheckApiOptions>();
        services.AddScoped<ISpellCheckIntegrationService, SpellCheckIntegrationService>();

        services.AddHttpClient<ISpellCheckIntegrationService, SpellCheckIntegrationService>(
                client => { client.BaseAddress = new Uri(spellCheckApiOptions!.Url); }
            );

        return services;
    }
}