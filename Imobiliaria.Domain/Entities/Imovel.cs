

using System.Runtime.CompilerServices;
using Microsoft.Build.Framework;

namespace Imobiliaria.Domain.Entities
{
    public class Imovel
    {
        public int ImovelId { get; set; }
        public string Tipo { get; set; }
        public int Quartos { get; set; }
        public virtual Endereco Endereco { get; set; }
        public bool Vendido { get; set; }

    }
}
