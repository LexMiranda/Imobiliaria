

using System.Collections.Generic;

namespace Imobiliaria.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public IEnumerable<Imovel> Imoveis { get; set; }
    }
}
