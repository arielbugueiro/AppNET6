using Microsoft.AspNetCore.Mvc.Versioning;

namespace Pacagroup.Ecommerce.Services.WebApi.Modules.Versioning
{
    public static class VersioningExtensions
    {
        public static IServiceCollection AddVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(o =>
            {
                o.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                o.AssumeDefaultVersionWhenUnspecified = true;
                o.ReportApiVersions = true;
                //o.ApiVersionReader = new QueryStringApiVersionReader("api-version"); // 1- Utilizo Query String (mando el versionado por Parámetros de Consulta)
                //o.ApiVersionReader = new HeaderApiVersionReader("x-version"); // 2- Utilizo Encabezado personalizado (Header)
                o.ApiVersionReader = new UrlSegmentApiVersionReader(); // 3- Utilizo Parámetros en la URI (Path)
            });

            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV"; //VVV (major.minor.patch) versionado semántico
                options.SubstituteApiVersionInUrl = true;
            });

            return services;
        }
    }
}