using ServerPart_Tours.Servises;

namespace ServerPart_Tours.EndPoints
{
    public static class TypesEndPoints
    {
        public static IEndpointRouteBuilder MapTypesEndPoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/typeslist", (TypesService typesService) => typesService.GetTypesList());

            return app;
        }
    }
}
