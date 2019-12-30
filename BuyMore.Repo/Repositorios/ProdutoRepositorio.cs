using BuyMore.Dom.Contratos;
using BuyMore.Dom.Entidades;
using BuyMore.Repo.Contexto;

namespace BuyMore.Repo.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(AppDbContexto Context) : base(Context)
        {
        }
    }
}