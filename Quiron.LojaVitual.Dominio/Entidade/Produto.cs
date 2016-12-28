using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVitual.Dominio.Entidade{
    public class Produto{
        public int produtoId { get; set; }
        public String nome { get; set; }
        public String descricao { get; set; }
        public decimal preco { get; set; }
        public String categoria { get; set; }


    }
}
