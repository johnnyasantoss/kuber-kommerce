using KuberKommerce.Shared.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace KuberKommerce.Shared.Services
{
    public static class ServicesExtensions
    {
        public static void AddKuberKommerceShared(this IServiceCollection services)
        {
            services.AddSingleton<IHttpService>(new HttpService());
        }
    }
}