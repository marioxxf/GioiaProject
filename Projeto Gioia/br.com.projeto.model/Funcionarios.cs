using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Gioia.br.com.projeto.model
{
    public class Funcionarios : Fornecedores
    {
        // Atributos + getters e setters
        public string senha { get; set; }
        public string cargo { get; set; }
        public string nivel_acesso { get; set; }
    }
}
