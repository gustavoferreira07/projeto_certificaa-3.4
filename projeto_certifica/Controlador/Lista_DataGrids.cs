using MySql.Data.MySqlClient;
using projeto_certifica.telas;
using projeto_certifica.utilitario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_certifica.Controlador
{
    class Lista_DataGrids
    {

        Conexao conexao = new Conexao();
     

        public DataSet listarTodos()
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da;
            da = new MySqlDataAdapter("select id_usuario, nm_usuario, nm_cargo from tb_usuario; select id_ocorrencia, nm_usuario, status_ocorrencia, cpf_proprietario, placa from tb_ocorrencia; select * from tb_historico; select * from tb_orcamento", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;
        }
        
    }
}
