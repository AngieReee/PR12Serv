using ServerPart_Tours.Models;

namespace ServerPart_Tours.Repositories
{
    /// <summary>
    /// подключение к бд
    /// </summary>
    public class BaseRepository
    {
        readonly protected PostgresContext baseContext;
        public BaseRepository(PostgresContext baseContext)
        {
            this.baseContext = baseContext;
        }
    }
}
