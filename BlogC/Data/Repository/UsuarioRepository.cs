using BlogC.Data.Interfaz;
using BlogC.Data.Models;

namespace BlogC.Data.Repository
{
    public class UsuarioRepository:GenericRepository<UsuarioModels>, IUsuarioRepository
    {
        public UsuarioRepository(NoticiasContext context) : base(context) { }
    }
}
