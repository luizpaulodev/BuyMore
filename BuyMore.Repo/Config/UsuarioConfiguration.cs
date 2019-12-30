using BuyMore.Dom.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuyMore.Repo.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);

            // Builder padrão Fluent, chamar as funções de forma encadeadas
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Senha).IsRequired();
            builder.Property(u => u.Nome).IsRequired();           
            builder.Property(u => u.Sobrenome).IsRequired();

            builder.HasMany(u => u.Pedidos).WithOne(p => p.Usuario);
        }
    }
}