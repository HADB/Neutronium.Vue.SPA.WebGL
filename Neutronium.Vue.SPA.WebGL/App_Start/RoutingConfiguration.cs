using Neutronium.BuildingBlocks.Application.Navigation;
using Neutronium.Core.Navigation.Routing;

namespace Neutronium.Vue.SPA.WebGL
{
    public class RoutingConfiguration
    {
        public static IRouterSolver Register()
        {
            var router = new Router();
            BuildRoutes(router);
            return router;
        }

        private static void BuildRoutes(IRouterBuilder routeBuilder)
        {
            var convention = routeBuilder.GetTemplateConvention("{vm}");
            typeof(RoutingConfiguration).GetTypesFromSameAssembly()
                .InNamespace("Neutronium.Vue.SPA.WebGL.ViewModel")
                .Register(convention);
        }
    }
}
