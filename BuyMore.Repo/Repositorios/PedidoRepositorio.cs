using BuyMore.Dom.Contratos;
using BuyMore.Dom.Entidades;
using BuyMore.Repo.Contexto;

namespace BuyMore.Repo.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(AppDbContexto Context) : base(Context)
        {

        }
    }
}