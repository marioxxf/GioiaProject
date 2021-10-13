using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Gioia.br.com.projeto.model
{
    public class Produtos
    {
        // Atributos + getters e setters
        public int id  { get; set; }
        public string descricao { get; set; }
        public decimal preco_custo { get; set; }
        public decimal preco_venda { get; set; }
        public int qtd_estoque { get; set; }
        public int for_id { get; set; }
    }
}
