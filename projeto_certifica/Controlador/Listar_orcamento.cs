using MySql.Data.MySqlClient;
using projeto_certifica.utilitario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_certifica.Controlador
{
    class Listar_orcamento
    {
        Conexao conexao = new Conexao();


        public DataSet ListarOcorrencia(string id)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da;
            da = new MySqlDataAdapter("select * from tb_orcamento where id_ocorrencia like '%"+id+"%'", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;
        }
    }
}
