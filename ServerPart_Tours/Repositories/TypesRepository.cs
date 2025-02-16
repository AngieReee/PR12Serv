using Microsoft.EntityFrameworkCore;
using ServerPart_Tours.Models;

namespace ServerPart_Tours.Repositories
{
    public class TypesRepository: BaseRepository 
    {
        public TypesRepository(PostgresContext baseContext) : base(baseContext) { }

        public async Task<List<Models.Type>> GetToursTypes() =>
            await baseContext.Types.ToListAsync();
    }
}
