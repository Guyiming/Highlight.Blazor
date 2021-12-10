using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace HighlightBlazor
{
    public static class ServiceCollectionExt
    {
        public static IServiceCollection AddHighlight(this IServiceCollection services)
        {
            return services.AddScoped<HighlightService>();
        }
    }
}
