using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace projeto_certifica.utilitario
{
    class Conexao
    {
        //192.168.1.33
        MySqlConnection con = new MySqlConnection("host= 127.0.0.1; userid= root ; password=; database=db_ocorrencia");

        public MySqlConnection ConectarBD()
        {
            try
            {
                con.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao conectar banco de dados. \nDetalhes do erro: " + e);
            }
            return con;
        }

        public MySqlConnection DesconectarBD()
        {
            try
            {
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao desconectar banco de dados. \nDetalhes do erro: " + e);
            }
            return con;
        }

        public void ChecarSetiveAberFecha()
        {
            try
            {
                if (con != null && con.State != System.Data.ConnectionState.Closed)
                {
                    DesconectarBD();
                }
            }
            catch
            {

            }
        }





    }
}
