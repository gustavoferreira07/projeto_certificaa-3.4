using MySql.Data.MySqlClient;
using projeto_certifica.utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_certifica.Controlador
{
    class SalvarUsuario
    {
        Conexao conexao = new Conexao();
        MySqlCommand comando = new MySqlCommand();


        public void salvarUsuario( Usuario usuario)
        {
            comando.CommandText = "insert into tb_usuario (nm_usuario, nm_senha, nm_cargo)  values('" + usuario.User + "','" + usuario.Senha + "','" + usuario.Cargo + "')";

            comando.Connection = conexao.ConectarBD();



            try
            {

                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception e)
            {
                MessageBox.Show("Falha ao cadastrar usuario. \n Detalhes do erro: " + e.Message);
            }
            conexao.DesconectarBD();
        }

    }
}
