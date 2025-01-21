using ServerPart_Tours.Servises;

namespace ServerPart_Tours.EndPoints
{
    public static class ToursEndPoints
    {
        public static IEndpointRouteBuilder MapToursEndPoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/tourslist", (ToursService toursService) => toursService.GetToursList());

            return app;
        }
    }
}
