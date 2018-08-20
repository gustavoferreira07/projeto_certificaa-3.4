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
    class Salva_edit
    {
        Conexao conexao = new Conexao();

        public void salvaredit(Ocorrencia ocorrencia, string id)
        {

            MySqlCommand comando = new MySqlCommand();

            // comando.CommandType = CommandType.Text;


            comando.CommandText = "update tb_ocorrencia set status_ocorrencia=@status,nm_proprietario=@nm_proprietario" +
            ", cpf_proprietario=@cpf,celular_proprietario=@celular,endereco_proprietario=@endereco,rg_proprietario=@rg,cnh_proprietario=@cnh,renavan=@renavan,modelo_carro=@carro" +
            ",placa=@placa,cor=@cor,ano=@ano,ds_ocorrencia=@descricao,data_entrada=@data_entrada,hora_entrada=@hora_entrada,area=@area" +
            ",pergunta1=@pg1,pergunta2=@pg2,pergunta3=@pg3,pergunta4=@pg4,pergunta5=@pg5,pergunta6=@pg6,pergunta7=@pg7,pergunta8=@pg8 where id_ocorrencia='"+id+"'";
            // comando.Parameters.Add("@id_ocorrencia", MySqlDbType.VarChar).Value = ocorrencia.Nm_ocorrencia;
           
            comando.Parameters.Add("@status", MySqlDbType.VarChar).Value = ocorrencia.Status;
            comando.Parameters.Add("@nm_proprietario", MySqlDbType.VarChar).Value = ocorrencia.Nome_proprietario;
            comando.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = ocorrencia.Cpf;
            comando.Parameters.Add("@celular", MySqlDbType.VarChar).Value = ocorrencia.Celular;
            comando.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = ocorrencia.Endereco;
            comando.Parameters.Add("@rg", MySqlDbType.VarChar).Value = ocorrencia.Rg;
            comando.Parameters.Add("@cnh", MySqlDbType.VarChar).Value = ocorrencia.Cnh;
            comando.Parameters.Add("@renavan", MySqlDbType.VarChar).Value = ocorrencia.Renavan;
            comando.Parameters.Add("@carro", MySqlDbType.VarChar).Value = ocorrencia.Modelo;
            comando.Parameters.Add("@placa", MySqlDbType.VarChar).Value = ocorrencia.Placa;
            comando.Parameters.Add("@cor", MySqlDbType.VarChar).Value = ocorrencia.Cor;
            comando.Parameters.Add("@ano", MySqlDbType.VarChar).Value = ocorrencia.Ano;
            comando.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = ocorrencia.Descricao;
            comando.Parameters.Add("@data_entrada", MySqlDbType.VarChar).Value = ocorrencia.Data_entrada;
            comando.Parameters.Add("@hora_entrada", MySqlDbType.VarChar).Value = ocorrencia.Hora_entrada;
            comando.Parameters.Add("@area", MySqlDbType.VarChar).Value = ocorrencia.Area;
            comando.Parameters.Add("@pg1", MySqlDbType.VarChar).Value = ocorrencia.Questao1;
            comando.Parameters.Add("@pg2", MySqlDbType.VarChar).Value = ocorrencia.Questao2;
            comando.Parameters.Add("@pg3", MySqlDbType.VarChar).Value = ocorrencia.Questao3;
            comando.Parameters.Add("@pg4", MySqlDbType.VarChar).Value = ocorrencia.Questao4;
            comando.Parameters.Add("@pg5", MySqlDbType.VarChar).Value = ocorrencia.Questao5;
            comando.Parameters.Add("@pg6", MySqlDbType.VarChar).Value = ocorrencia.Questao6;
            comando.Parameters.Add("@pg7", MySqlDbType.VarChar).Value = ocorrencia.Questao7;
            comando.Parameters.Add("@pg8", MySqlDbType.VarChar).Value = ocorrencia.Questao8;

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
        public void salvarHistorico(Historico historico)
        {
            MySqlCommand comando = new MySqlCommand();
           
            comando.CommandText = "insert into tb_historico (id_ocorrencia,nm_usuario,data_edit) values('" + historico.Id_ocorrencia + "','" + historico.Nm_usuario+"',@data)" ;
            comando.Parameters.Add("@data", MySqlDbType.DateTime).Value = historico.Data_edit;
            comando.Connection = conexao.ConectarBD();


            try
            {
                comando.ExecuteNonQuery();
                
            }
            catch(Exception e)
            {
                MessageBox.Show( e.Message);
            }

            comando.Connection = conexao.DesconectarBD();
        }

        public void AprovaStatusOcorrencia(Ocorrencia ocorrencia)
        {
            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = "update tb_ocorrencia set status_ocorrencia ='" + ocorrencia.Status + "' where id_ocorrencia='" + Variaveis_globais.id_ocorrencia + "'";
            comando.Connection = conexao.ConectarBD();


            try
            {
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            comando.Connection = conexao.DesconectarBD();
        }

        public void ReprovaStatusOcorrencia(Ocorrencia ocorrencia)
        {
            MySqlCommand comando = new MySqlCommand();

            comando.CommandText = "update tb_ocorrencia set status_ocorrencia ='"+ocorrencia.Status +"' where id_ocorrencia='"+Variaveis_globais.id_ocorrencia +"'";
            comando.Connection = conexao.ConectarBD();


            try
            {
                comando.ExecuteNonQuery();
               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            comando.Connection = conexao.DesconectarBD();
        }

    }
   
}
