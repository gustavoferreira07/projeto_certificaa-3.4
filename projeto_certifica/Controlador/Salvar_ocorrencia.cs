using MySql.Data.MySqlClient;
using projeto_certifica.Repositorio;
using projeto_certifica.telas;
using projeto_certifica.utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_certifica.Controlador
{
    class Salvar_ocorrencia
    {
        Conexao conexao = new Conexao();


        public void salvar_Ocorrencia(Ocorrencia ocorrencia)
        {

            MySqlCommand comando = new MySqlCommand();
            tela_gerar_ocorrencia tela = new tela_gerar_ocorrencia();
            comando.CommandType = System.Data.CommandType.Text;

            comando.CommandText = "insert into tb_ocorrencia( id_ocorrencia, nm_usuario, status_ocorrencia,nm_proprietario, cpf_proprietario, celular_proprietario,endereco_proprietario,rg_proprietario,cnh_proprietario,renavan,modelo_carro,placa,cor,ano,ds_ocorrencia,data_entrada,hora_entrada,area,img_entrada,img_saida,img_avaria,img_ocorrencia, pergunta1,pergunta2,pergunta3,pergunta4,pergunta5,pergunta6,pergunta7,pergunta8)" +
                "values(@nm_ocorrencia,@nm_usuario,@status,@nome_prop,@cpf,@celular,@endereco,@rg,@cnh,@renavan,@modelo,@placa,@cor,@ano,@descricao,@data_entrada,@hora_entrada,@area,@img_entrada,@img_saida,@img_avaria,@img_ocorrencia,@qt1,@qt2,@qt3,@qt4,@qt5,@qt6,@qt7,@qt8)";

            comando.Parameters.Add("@nm_ocorrencia", MySqlDbType.VarChar).Value = ocorrencia.Nm_ocorrencia;
            comando.Parameters.Add("@nm_usuario", MySqlDbType.VarChar).Value = ocorrencia.Nm_usuario;
            comando.Parameters.Add("@status", MySqlDbType.VarChar).Value = ocorrencia.Status;
            comando.Parameters.Add("@nome_prop", MySqlDbType.VarChar).Value = ocorrencia.Nome_proprietario;
            comando.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = ocorrencia.Cpf;
            comando.Parameters.Add("@celular", MySqlDbType.VarChar).Value = ocorrencia.Celular;
            comando.Parameters.Add("@endereco", MySqlDbType.VarChar).Value = ocorrencia.Endereco;
            comando.Parameters.Add("@rg", MySqlDbType.VarChar).Value = ocorrencia.Rg;
            comando.Parameters.Add("@cnh", MySqlDbType.VarChar).Value = ocorrencia.Cnh;
            comando.Parameters.Add("@renavan", MySqlDbType.VarChar).Value = ocorrencia.Renavan;
            comando.Parameters.Add("@modelo", MySqlDbType.VarChar).Value = ocorrencia.Modelo;
            comando.Parameters.Add("@placa", MySqlDbType.VarChar).Value = ocorrencia.Placa;
            comando.Parameters.Add("@cor", MySqlDbType.VarChar).Value = ocorrencia.Cor;
            comando.Parameters.Add("@ano", MySqlDbType.VarChar).Value = ocorrencia.Ano;
            comando.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = ocorrencia.Descricao;
            comando.Parameters.Add("@data_entrada", MySqlDbType.VarChar).Value = ocorrencia.Data_entrada;
            comando.Parameters.Add("@hora_entrada", MySqlDbType.VarChar).Value = ocorrencia.Hora_entrada;
            comando.Parameters.Add("@area", MySqlDbType.VarChar).Value = ocorrencia.Area;
            comando.Parameters.Add("@img_entrada", MySqlDbType.LongBlob).Value = ocorrencia.Img_entrada;
            comando.Parameters.Add("@img_saida", MySqlDbType.LongBlob).Value = ocorrencia.Img_saida;
            comando.Parameters.Add("@img_avaria", MySqlDbType.LongBlob).Value = ocorrencia.Img_avaria;
            comando.Parameters.Add("@img_ocorrencia", MySqlDbType.LongBlob).Value = ocorrencia.Img_ocorrencia;
            comando.Parameters.Add("@qt1", MySqlDbType.VarChar).Value = ocorrencia.Questao1;
            comando.Parameters.Add("@qt2", MySqlDbType.VarChar).Value = ocorrencia.Questao2;
            comando.Parameters.Add("@qt3", MySqlDbType.VarChar).Value = ocorrencia.Questao3;
            comando.Parameters.Add("@qt4", MySqlDbType.VarChar).Value = ocorrencia.Questao4;
            comando.Parameters.Add("@qt5", MySqlDbType.VarChar).Value = ocorrencia.Questao5;
            comando.Parameters.Add("@qt6", MySqlDbType.VarChar).Value = ocorrencia.Questao6;
            comando.Parameters.Add("@qt7", MySqlDbType.VarChar).Value = ocorrencia.Questao7;
            comando.Parameters.Add("@qt8", MySqlDbType.VarChar).Value = ocorrencia.Questao8;
            comando.Connection = conexao.ConectarBD();

            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Ocorrência salva com sucesso!", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception e)
            {
                MessageBox.Show("Falha ao salvar. \n Detalhesdo Erro:" + e);
            }
            conexao.DesconectarBD();

        }







    }
}
