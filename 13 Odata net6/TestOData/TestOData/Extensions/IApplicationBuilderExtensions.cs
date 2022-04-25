using Microsoft.OData.ModelBuilder;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class IApplicationBuilderExtensions
    {
        public static IApplicationBuilder RegisterOData(this IApplicationBuilder appBuilder)
        {
/*            var oDataConventionModelBuilder = new ODataConventionModelBuilder(appBuilder.ApplicationServices);

            appBuilder.ApplicationServices
                .GetRequiredService<IEnumerable<IODataRoutesRegistrar>>()
                .ToList()
                .ForEach(r => r.Register(appBuilder.ApplicationServices, ref oDataConventionModelBuilder));

            appBuilder.UseOData("odata", "odata", oDataConventionModelBuilder.GetEdmModel());*/

            return appBuilder;
        }
    }
}
