

using System.Runtime.CompilerServices;
using Microsoft.Build.Framework;

namespace Imobiliaria.Domain.Entities
{
    public class Imovel
    {
        public int ImovelId { get; set; }
        public string Tipo { get; set; }
        public int Quartos { get; set; }
        public Endereco Endereco { get; set; }
        
    }
}
