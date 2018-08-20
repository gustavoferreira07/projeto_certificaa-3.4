using MySql.Data.MySqlClient;
using projeto_certifica.Controlador;
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
    public partial class tela_consulta_usuario : Form
    {
        public tela_consulta_usuario()
        {
            InitializeComponent();
        }

        Conexao conexao = new Conexao();

        Lista_DataGrids listar = new Lista_DataGrids();
        string id_usuario;
        tela_alterar_senha tela = new tela_alterar_senha();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_usuario = (dataGridView1.Rows[e.RowIndex].Cells["id_usuario"].Value).ToString();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            /*
            tela.Show();
            MySqlDataReader dr;
            Conexao con = new Conexao();
            MySqlCommand cmd = new MySqlCommand("select * from tb_usuario where id_usuario=@id", con.ConectarBD());
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id_usuario;
            dr = cmd.ExecuteReader();
            try
            {
                if (dr.HasRows == false)
                {
                    MessageBox.Show("Nenhum usuario encontrado !");
                }
                else
                {
                    while (dr.Read())
                    {
                        //   tela_editar tela = new tela_editar();
                        tela.txtUsu.Text = dr[1].ToString();
                        tela.txtSenhaAtual.Text = dr[2].ToString();                       
                    }
                    con.DesconectarBD();
                    con.ConectarBD();
                    con.DesconectarBD();
                }
            }
            catch
            {

            }*/
        }

        private void tela_consulta_usuario_Load(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            ds = listar.listarTodos();
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            dataGridView1.Columns[0].HeaderText = "Id funcionario";
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "Nível acesso";
        }

        public DataSet ListarUsuario()
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da;
            da = new MySqlDataAdapter("select * from tb_usuario  where nm_usuario like '%" + textBox1.Text +"%'", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = ListarUsuario();
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            dataGridView1.Columns[0].HeaderText = "Id funcionario";
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "Nível acesso";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = listar.listarTodos();
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
            dataGridView1.Columns[0].HeaderText = "Id funcionario";
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "Nível acesso";
        }
    }
}
