using BuyMore.Dom.Enumerados;

namespace BuyMore.Dom.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool EhBoleto { get { return Id == (int)TipoFormaPagamentoEnum.Boleto; } }
        public bool EhCartaoCredito { get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; } }
        public bool EhDeposito { get { return Id == (int)TipoFormaPagamentoEnum.Deposito; } }
        public bool NaoDefinido { get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; } }
    }
}