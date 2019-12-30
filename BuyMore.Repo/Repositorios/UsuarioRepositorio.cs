using BuyMore.Dom.Contratos;
using BuyMore.Dom.Entidades;
using BuyMore.Repo.Contexto;

namespace BuyMore.Repo.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(AppDbContexto Context) : base(Context)
        {
        }
    }
}