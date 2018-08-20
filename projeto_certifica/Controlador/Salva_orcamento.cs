using MySql.Data.MySqlClient;
using projeto_certifica.Repositorio;
using projeto_certifica.utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_certifica.Controlador
{
    class Salva_orcamento
    {
        Conexao conexao = new Conexao();
        MySqlCommand comando = new MySqlCommand();


        public void SalvarOrcamento(Orcamento orcamento)
        {
            comando.CommandText = "insert into tb_orcamento (id_ocorrencia, status_orcamento,tipo_orcamento,ds_orcamento,data_conclusao,valor, motivo_status )  values('" +orcamento.Id_ocorrencia + "','" + orcamento.Status_orcamento + "','" + orcamento.Tipo_orcamento + "','" +orcamento.Ds_orcamento+ "','" +orcamento.Data_conclusao+ "','" +orcamento.Valor+ "','" +orcamento.Motivo_Status+ "')";

            comando.Connection = conexao.ConectarBD();



            try
            {

                comando.ExecuteNonQuery();
                MessageBox.Show("Orçamento Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao cadastrar orçamento. \n Detalhes do erro: " + e.Message);
            }
            conexao.DesconectarBD();
        }
        public void SalvarEdit(Orcamento orcamento, string id)
        {

            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = "update tb_orcamento set status_orcamento=@status , tipo_orcamento=@tipo, ds_orcamento=@ds_orcamento, data_conclusao=@data,valor=@valor, motivo_status=@motivo where id_ocorrencia=" + id+" and id_orcamento="+Variaveis_globais.id_orcamento;
           
            comando.Parameters.Add("@status", MySqlDbType.VarChar).Value = orcamento.Status_orcamento;
            comando.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = orcamento.Tipo_orcamento;
            comando.Parameters.Add("@ds_orcamento", MySqlDbType.VarChar).Value = orcamento.Ds_orcamento;
            comando.Parameters.Add("@data", MySqlDbType.VarChar).Value = orcamento.Data_conclusao;
            comando.Parameters.Add("@valor", MySqlDbType.VarChar).Value = orcamento.Valor;
            comando.Parameters.Add("@motivo", MySqlDbType.VarChar).Value = orcamento.Motivo_Status;
            comando.Connection = conexao.ConectarBD();
            
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Alterado com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao alterar. \n Detalhesdo Erro:" + e);
            }
            //Desconectar pela ultima vez
            comando.Connection = conexao.DesconectarBD();
        }

        public void SalvaRecibo(Orcamento orc)
        {
            Conexao conexao = new Conexao();
            Orcamento orca = new Orcamento();
            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = "update tb_orcamento set img_recibo=@img where id_orcamento='" + Variaveis_globais.id_orcamento + "'";
            comando.Parameters.Add("@img", MySqlDbType.LongBlob).Value = orc.Img_recibo;
            comando.Connection = conexao.ConectarBD();

            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("salvo com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar. \n Detalhesdo Erro:" + ex);
            }
            //Desconectar pela ultima vez
            comando.Connection = conexao.DesconectarBD();

        }
    }
    
}

