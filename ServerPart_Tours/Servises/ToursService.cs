using Newtonsoft.Json;
using ServerPart_Tours.Repositories;

namespace ServerPart_Tours.Servises
{
    public class ToursService
    {
        readonly ToursRepository repository;
        
        public ToursService(ToursRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// преобразование списка со всеми турами в json
        /// </summary>
        /// <returns></returns>
        public async Task<IResult> GetToursList() => Results.
            Text(JsonConvert.SerializeObject(
                await repository.GetTours(),
                Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                }));
    }
}
