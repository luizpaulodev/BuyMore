using BuyMore.Dom.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuyMore.Repo.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.ProdutoId).IsRequired();
            builder.Property(i => i.Quantidade).IsRequired();
        }
    }
}