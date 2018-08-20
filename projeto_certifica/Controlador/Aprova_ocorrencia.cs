using MySql.Data.MySqlClient;
using projeto_certifica.Repositorio;
using projeto_certifica.telas;
using projeto_certifica.utilitario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_certifica.Controlador
{
    class Aprova_ocorrencia
    {
        Conexao conexao = new Conexao();

        public void aprova_edit(Orcamento orcamento)
        {
            string aprova = "APROVADA PELA GERÊNCIA";
            MySqlCommand comando = new MySqlCommand();
           
            comando.CommandType = CommandType.Text;


            comando.CommandText = "update tb_orcamento set status_orcamento=@aprovado , motivo_status=@motivo where id_ocorrencia="+Variaveis_globais.id_ocorrencia+" and id_orcamento ="+Variaveis_globais.id_orcamento;
            comando.Parameters.Add("@aprovado", MySqlDbType.VarChar).Value = aprova;
            comando.Parameters.Add("@motivo", MySqlDbType.VarChar).Value = orcamento.Motivo_Status;

            comando.Connection = conexao.ConectarBD();

            try
            {

                comando.ExecuteNonQuery();
                MessageBox.Show("Aprovado com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao aprovar . \n Detalhesdo Erro:" + e);

            }
            //Desconectar pela ultima vez
            comando.Connection = conexao.DesconectarBD();
        }

        public void reprova_edit(Orcamento orcamento)
        {
            string reprova = "REPROVADA PELA GERÊNCIA";
            MySqlCommand comando = new MySqlCommand();
           
            comando.CommandType = CommandType.Text;


            comando.CommandText = "update tb_orcamento set status_orcamento=@aprovado , motivo_status=@motivo where id_ocorrencia=" + Variaveis_globais.id_ocorrencia+" and id_orcamento="+Variaveis_globais.id_orcamento;
            comando.Parameters.Add("@aprovado", MySqlDbType.VarChar).Value = reprova;
            comando.Parameters.Add("@motivo", MySqlDbType.VarChar).Value = orcamento.Motivo_Status;
            comando.Connection = conexao.ConectarBD();
            try
            {

                comando.ExecuteNonQuery();
                MessageBox.Show("Reprovado com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
               

            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao aprovar . \n Detalhesdo Erro:" + e);

            }
            //Desconectar pela ultima vez
            comando.Connection = conexao.DesconectarBD();
        }
    }
}
