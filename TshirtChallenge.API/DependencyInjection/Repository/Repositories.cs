using TshirtChallenge.Domain.Interfaces.Repositories;
using TshirtChallenge.Infra.Repositories;

namespace TshirtChallenge.API.DependencyInjection.Repository
{
    public class Repositories
    {
        public void AddRepositoriesDependencyInjection(IServiceCollection services)
        {
            services.AddScoped<IImageRepository, ImageRepository>();
            services.AddScoped<ITshirtRepository, TshirtRepository>();
            services.AddScoped<ITypeRepository, TypeRepository>();
        }
    }
}
