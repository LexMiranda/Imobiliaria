

using System.Collections.Generic;

namespace Imobiliaria.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public virtual Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool Comprador { get; set; }
        public bool Proprietario { get; set; }
        public virtual IEnumerable<Imovel> Imoveis { get; set; }
        public virtual int ImovelID { get; set; }

    }
}
