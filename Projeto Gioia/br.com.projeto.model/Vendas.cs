using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Gioia.br.com.projeto.model
{
    public class Vendas
    {
        // Atributos + getters e setters
        public int id { get; set; }
        public int cliente_id { get; set; }
        public DateTime data_venda { get; set; }
        public decimal total_venda { get; set; }
        public string obs { get; set; }
    }
}
