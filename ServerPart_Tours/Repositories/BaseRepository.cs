using ServerPart_Tours.Models;

namespace ServerPart_Tours.Repositories
{
    /// <summary>
    /// подключение к бд
    /// </summary>
    public class BaseRepository
    {
        readonly protected _43pToursContext baseContext;
        public BaseRepository(_43pToursContext baseContext) {
            this.baseContext = baseContext;
        }
    }
}
