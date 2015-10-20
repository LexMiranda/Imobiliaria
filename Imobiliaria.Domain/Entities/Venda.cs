using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imobiliaria.Domain.Entities
{
    public class Venda
    {
        public int VendaID { get; set; }
        public int CompradorID { get; set; }
        public int ProprietarioID { get; set; }
        public int ImovelID { get; set; }
        public decimal ValorDaVenda { get; set; }
        public DateTime DataDaVenda { get; set; }
    }
}
