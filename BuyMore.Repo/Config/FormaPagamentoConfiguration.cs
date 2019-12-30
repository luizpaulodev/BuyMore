using BuyMore.Dom.Enumerados;
using BuyMore.Dom.ObjetoDeValor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuyMore.Repo.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Nome).IsRequired();
            builder.Property(f => f.Descricao).IsRequired();

            builder.HasData(
                new FormaPagamento {
                    Id = (int) TipoFormaPagamentoEnum.NaoDefinido,
                    Nome = "Boleto",
                    Descricao = "Não foi definido a forma de pagamento"
                },
                new FormaPagamento {
                    Id = (int) TipoFormaPagamentoEnum.Boleto,
                    Nome = "Boleto",
                    Descricao = "Forma de pagamento por boleto bancário"
                },
                new FormaPagamento {
                    Id = (int) TipoFormaPagamentoEnum.CartaoCredito,
                    Nome = "Boleto",
                    Descricao = "Forma de pagamento por cartão de crédito"
                },
                new FormaPagamento {
                    Id = (int) TipoFormaPagamentoEnum.Deposito,
                    Nome = "Depósito",
                    Descricao = "Forma de pagamento por depósito bancário"
                }
            );
        }
    }
}