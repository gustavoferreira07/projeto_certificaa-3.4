using MySql.Data.MySqlClient;
using projeto_certifica.Repositorio;
using projeto_certifica.utilitario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_certifica.telas
{
    public partial class tela_adiciona_servico : Form
    {
        public tela_adiciona_servico()
        {
            InitializeComponent();
        }

        
        Conexao conexao = new Conexao();
        MySqlCommand comando = new MySqlCommand();

        private void button1_Click(object sender, EventArgs e)
        {
            comando.CommandText = "insert into tb_servico (nm_servico)  values('" + textBox1.Text + "')";

            comando.Connection = conexao.ConectarBD();



            try
            {

                comando.ExecuteNonQuery();
                MessageBox.Show("Serviço Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao cadastrar serviço. \n Detalhes do erro: " + ex.Message);
            }
            conexao.DesconectarBD();
        }
    }
}
