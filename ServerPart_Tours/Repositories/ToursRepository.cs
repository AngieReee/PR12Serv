using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using ServerPart_Tours.Models;

namespace ServerPart_Tours.Repositories
{
    public class ToursRepository : BaseRepository
    {
        public ToursRepository(PostgresContext baseContext) : base(baseContext) { }

        /// <summary>
        /// метод для получения списка со всеми отелями
        /// </summary>
        /// <returns></returns>
        public async Task<List<Tour>> GetTours() => await baseContext.Tours.
            Include(x => x.ToursTypes).ToListAsync();
    }
}
