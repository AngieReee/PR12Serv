using Newtonsoft.Json;
using ServerPart_Tours.Repositories;

namespace ServerPart_Tours.Servises
{
    
    public class TypesService
    {
        readonly TypesRepository repository;

        public TypesService(TypesRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IResult> GetTypesList() => Results.
            Text(JsonConvert.SerializeObject(
                await repository.GetToursTypes(),
                Formatting.Indented,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                }));
    }
}
