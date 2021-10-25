using MySql.Data.MySqlClient;
using Projeto_Gioia.br.com.projeto.con;
using Projeto_Gioia.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Gioia.br.com.projeto.dao
{
    public class ItemVendaDAO
    {
        // Atributo
        private MySqlConnection conexao;

        // Construtor
        public ItemVendaDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        // Métodos
        #region Método responsável por cadastrar um item de venda
        public void CadastrarItemVenda(ItemVenda item)
        {
            string sql = @"insert into tb_itensvendas (venda_id, produto_id, qtd, subtotal)
                         values (@venda_id, @produto_id, @qtd, @subtotal)";

                MySqlCommand executasql = new MySqlCommand(sql, conexao);
                
                executasql.Parameters.AddWithValue("@venda_id", item.venda_id);
                executasql.Parameters.AddWithValue("@produto_id", item.produto_id);
                executasql.Parameters.AddWithValue("@qtd", item.qtd);
                executasql.Parameters.AddWithValue("@subtotal", item.subtotal);

                conexao.Open();
                executasql.ExecuteNonQuery();
                conexao.Close();
        }
        #endregion
    }
}
