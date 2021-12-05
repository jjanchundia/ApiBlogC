using BlogC.Data.Interfaz;
using BlogC.Data.Models;

namespace BlogC.Data.Repository
{
    public class NoticiasRepository : GenericRepository<NoticiasModels>, INoticiasRepository
    {
        public NoticiasRepository(NoticiasContext context) : base(context){}
    }
}