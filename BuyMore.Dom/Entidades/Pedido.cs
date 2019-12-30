using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BuyMore.Dom.ObjetoDeValor;

namespace BuyMore.Dom.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }        
        public DateTime DataPrevisaoEntrega { get; set; }
        public String CEP { get; set; }
        public String Estado { get; set; }
        public String Cidade { get; set; }
        public String EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um item de pedido ou muitos itens de pedidos
        /// </summary>
        public virtual ICollection<ItemPedido> ItensPedidos { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (!ItensPedidos.Any())
                AdicionarCritica("Lista de Pedido não pode ficar sem pedido!");

            if (String.IsNullOrEmpty(CEP))
                AdicionarCritica("CEP deve estar preenchido");

            if (FormaPagamentoId == 0)
                AdicionarCritica("Não foi informado a forma de pagamento");
        }
    }
}
