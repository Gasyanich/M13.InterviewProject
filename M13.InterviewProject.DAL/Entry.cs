using M13.InterviewProject.BLL.Abstractions;
using M13.InterviewProject.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace M13.InterviewProject.DAL;

public static class Entry
{
    public static IServiceCollection AddDal(this IServiceCollection services)
    {
        services.AddSingleton<IRulesRepository, RulesRepository>();
        return services;
    }
}