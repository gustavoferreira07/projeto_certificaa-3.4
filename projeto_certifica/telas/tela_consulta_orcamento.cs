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
    public partial class tela_consulta_orcamento : Form
    {
        public tela_consulta_orcamento()
        {
            InitializeComponent();
        }
        string id_ocorrencia;
        string id_orcamento;

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            MySqlDataReader dr;
            Conexao con = new Conexao();
            MySqlCommand cmd = new MySqlCommand("select * from tb_orcamento where id_orcamento=@id", con.ConectarBD());
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id_orcamento;

            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                tela_orcamento tela = new tela_orcamento();
                tela.Show();
                tela.btnEditar.Visible = true;
                if(Variaveis_globais.cargo== "Gerência")
                {
                    tela.btnAprovar.Visible = true;
                    tela.btnReproar.Visible = true;
                    tela.label5.Visible = true;
                    tela.txtMotivo.Visible = true;
                }
                while (dr.Read())
                {
                    tela.lblNOcorrencia.Text = dr[1].ToString();
                    tela.lblStatus.Text = dr[2].ToString();
                    tela.cbbServico.Text = dr[3].ToString();
                    tela.txtDsOcorrencia.Text = dr[4].ToString();
                    tela.dateTimePicker1.Text = dr[5].ToString();
                    tela.txtValor.Text = dr[6].ToString();
                    tela.txtMotivo.Text = dr[7].ToString();
                }

            }
            else
            {
                MessageBox.Show("Erro ao carregar orçamento !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_ocorrencia = (dataGridView1.Rows[e.RowIndex].Cells["id_ocorrencia"].Value).ToString();
            Variaveis_globais.id_ocorrencia = id_ocorrencia;

          

            id_orcamento = (dataGridView1.Rows[e.RowIndex].Cells["id_orcamento"].Value).ToString();
            Variaveis_globais.id_orcamento = id_orcamento;
        }

        private void tela_consulta_orcamento_Load(object sender, EventArgs e)
        {
            tela_consulta_ocorrencia telas = new tela_consulta_ocorrencia();

            Listar_orcamento listar = new Listar_orcamento();
            DataSet ds = new DataSet();
            ds = listar.ListarOcorrencia(Variaveis_globais.id_ocorrencia);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "N° Orçamento";
            dataGridView1.Columns[1].HeaderText = "N° Ocorrência";
            dataGridView1.Columns[2].HeaderText = "Status";
            dataGridView1.Columns[3].HeaderText = "Tipo orçamento";
            dataGridView1.Columns[4].HeaderText = "Descrição";
            dataGridView1.Columns[5].HeaderText = "Data conclusão";
            dataGridView1.Columns[6].HeaderText = "Valor";
            dataGridView1.Columns[7].HeaderText = "Motivo";
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listar_orcamento listar = new Listar_orcamento();
            DataSet ds = new DataSet();
            ds = listar.ListarOcorrencia(id_ocorrencia);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "N° Orçamento";
            dataGridView1.Columns[1].HeaderText = "N° Ocorrência";
            dataGridView1.Columns[2].HeaderText = "Status";
            dataGridView1.Columns[3].HeaderText = "Tipo orçamento";
            dataGridView1.Columns[4].HeaderText = "Descrição";
            dataGridView1.Columns[5].HeaderText = "Data conclusão";
            dataGridView1.Columns[6].HeaderText = "Valor";
            dataGridView1.Columns[7].HeaderText = "Motivo";
            dataGridView1.Refresh();
        }
    }
}
    