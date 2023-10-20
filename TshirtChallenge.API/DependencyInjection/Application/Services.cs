using TshirtChallenge.Application.Services;
using TshirtChallenge.Application.Services.Interfaces;

namespace TshirtChallenge.API.DependencyInjection.Application
{
    public class Services
    {
        public void AddServicesDependencyInjection(IServiceCollection services)
        {
            services.AddScoped<ITshirtService, TshirtService>();
            services.AddScoped<ITypeService, TypeService>();
            services.AddScoped<IImageService, ImageService>();
        }
    }
}
