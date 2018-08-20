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
    public partial class tela_historico : Form
    {
        public tela_historico()
        {
            InitializeComponent();
        }
        Lista_DataGrids listar = new Lista_DataGrids();
        Conexao conexao = new Conexao();

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtIdOcorrencia.Enabled = true;           
            dateTimePicker1.Enabled = false;          
        }

        private void tela_historico_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = listar.listarTodos();
            dataGridView1.DataSource = ds.Tables[2];
            dataGridView1.Columns[0].HeaderText = "ID historico";
            dataGridView1.Columns[1].HeaderText = "N° ocorrêmcia";
            dataGridView1.Columns[2].HeaderText = "Autor modificação";
            dataGridView1.Columns[3].HeaderText = "Data modificação";
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = listar.listarTodos();
            dataGridView1.DataSource = ds.Tables[2];
            dataGridView1.Columns[0].HeaderText = "ID historico";
            dataGridView1.Columns[1].HeaderText = "N° ocorrêmcia";
            dataGridView1.Columns[2].HeaderText = "Autor modificação";
            dataGridView1.Columns[3].HeaderText = "Data modificação";
            dataGridView1.Refresh();
        }

        public DataSet ListarId()
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da;
            da = new MySqlDataAdapter("select * from tb_historico where id_ocorrencia like '%" + txtIdOcorrencia.Text + "%'", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;
        }

        public DataSet ListarData()
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da;
            da = new MySqlDataAdapter("select * from tb_historico where data_edit like '%" + dateTimePicker1.Text + "%'", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                DataSet ds = new DataSet();
                ds = ListarId();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
                dataGridView1.Columns[0].HeaderText = "ID historico";
                dataGridView1.Columns[1].HeaderText = "N° ocorrêmcia";
                dataGridView1.Columns[2].HeaderText = "Autor modificação";
                dataGridView1.Columns[3].HeaderText = "Data modificação";
                dataGridView1.Refresh();
            }
            else if (radioButton3.Checked == true)
            {
                DataSet ds = new DataSet();
                ds = ListarData();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
                dataGridView1.Columns[0].HeaderText = "ID historico";
                dataGridView1.Columns[1].HeaderText = "N° ocorrêmcia";
                dataGridView1.Columns[2].HeaderText = "Autor modificação";
                dataGridView1.Columns[3].HeaderText = "Data modificação";
                dataGridView1.Refresh();
            }          
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtIdOcorrencia.Enabled = false;
           
            dateTimePicker1.Enabled = false;
            txtIdOcorrencia.Clear();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtIdOcorrencia.Enabled = false;
           
            dateTimePicker1.Enabled = true;
            txtIdOcorrencia.Clear();
           
        }
    }
}
