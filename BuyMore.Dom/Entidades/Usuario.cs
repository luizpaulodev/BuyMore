using System;
using System.Collections.Generic;
using System.Text;

namespace BuyMore.Dom.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public String Nome { get; set; }
        public String Sobrenome { get; set; }

        /// <summary>
        /// Um Usuário pode ter nenhum ou muitos pedidos
        /// </summary>
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (String.IsNullOrEmpty(Email))
                AdicionarCritica("Email não foi informado");

            if (String.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha não foi informado");
        }
    }
}
