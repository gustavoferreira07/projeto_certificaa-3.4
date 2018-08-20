using MySql.Data.MySqlClient;
using projeto_certifica.Controlador;
using projeto_certifica.Repositorio;
using projeto_certifica.utilitario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_certifica.telas
{
    public partial class tela_orcamento : Form
    {
        public tela_orcamento()
        {
            InitializeComponent();
        }
        Conexao conexao = new Conexao();
        Image vimagem1;
        Ocorrencia ocorrencia = new Ocorrencia();
        Aprova_ocorrencia salvar = new Aprova_ocorrencia();
       

        private void button1_Click(object sender, EventArgs e)
        {
            Orcamento orcamento = new Orcamento();
            Salva_orcamento salva = new Salva_orcamento();

            orcamento.Id_ocorrencia = lblNOcorrencia.Text;
            orcamento.Status_orcamento = lblStatus.Text;
            orcamento.Tipo_orcamento = cbbServico.Text;
            orcamento.Ds_orcamento = txtDsOcorrencia.Text;
            orcamento.Data_conclusao = dateTimePicker1.Text;
            orcamento.Valor = Convert.ToDouble(txtValor.Text);
            orcamento.Motivo_Status = txtMotivo.Text;

            salva.SalvarOrcamento(orcamento);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja mesmo APROVAR o resarcimento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resposta == DialogResult.Yes)
            {
                //ocorrencia.Nm_ocorrencia = lblNOcorrencia.Text;
                Orcamento orcamento = new Orcamento();
                orcamento.Motivo_Status = txtMotivo.Text;
                salvar.aprova_edit(orcamento);

                Ocorrencia ocorrencia = new Ocorrencia();
                ocorrencia.Status = "APROVADO PELA GERÊNCIA";
                Salva_edit salve = new Salva_edit();
                salve.AprovaStatusOcorrencia(ocorrencia);
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja mesmo REPROVAR o resarcimento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (resposta == DialogResult.Yes)
            {
                Orcamento orcamento = new Orcamento();
                orcamento.Motivo_Status = txtMotivo.Text;
                salvar.reprova_edit(orcamento);

                Ocorrencia ocorrencia = new Ocorrencia();
                ocorrencia.Status = "REPROVADO PELA GERÊNCIA";
                Salva_edit salve = new Salva_edit();
                salve.ReprovaStatusOcorrencia(ocorrencia);
            }
            else
            {

            }
        }

       
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Orcamento orcamento = new Orcamento();
            Salva_orcamento salva = new Salva_orcamento();

            orcamento.Id_ocorrencia = lblNOcorrencia.Text;
            orcamento.Status_orcamento = lblStatus.Text;
            orcamento.Tipo_orcamento = cbbServico.Text;
            orcamento.Ds_orcamento = txtDsOcorrencia.Text;
            orcamento.Data_conclusao = dateTimePicker1.Text;
            orcamento.Valor = Convert.ToDouble(txtValor.Text);
            orcamento.Motivo_Status = txtMotivo.Text;

            salva.SalvarEdit(orcamento, lblNOcorrencia.Text);
        }

        private void tela_orcamento_Load(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now.Date;
            dateTimePicker1.Text = Convert.ToString(data);
            preencherCBB();
        }
        private void preencherCBB()
        {
            Conexao con = new Conexao();
            try
            {
                con.ConectarBD();
                con.DesconectarBD();
            }

            catch (MySqlException sqle)
            {
                con.ConectarBD();
                MessageBox.Show("Falha ao efetuar a conexão. Erro: " + sqle);
            }
            String scom = "select * from tb_servico order by nm_servico";
            MySqlDataAdapter da = new MySqlDataAdapter(scom, con.ConectarBD());
            DataTable dtResultado = new DataTable();
            dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
            cbbServico.DataSource = null;
            da.Fill(dtResultado);
            cbbServico.DataSource = dtResultado;
            cbbServico.ValueMember = "id_servico";
            cbbServico.DisplayMember = "nm_servico";
            // cbbDesti.SelectedItem = "";
            cbbServico.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
            con.DesconectarBD();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            tela_adiciona_servico tela = new tela_adiciona_servico();
            tela.Show();
        }

        private void cbbServico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void RetornarImagem(PictureBox picture, Image vimagem, string id)
        {
            try
            {
                MySqlCommand cmdSelect = new MySqlCommand("select img_recibo from tb_orcamento where id_ocorrencia=@ID", conexao.ConectarBD());
                cmdSelect.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
                DataSet ds = new DataSet();
                MySqlDataAdapter sqlda = new MySqlDataAdapter(cmdSelect);
                sqlda.Fill(ds, "tb_orcamento");

                using (var stream = new System.IO.MemoryStream((byte[])ds.Tables["tb_orcamento"].Rows[0]["img_recibo"]))
                {
                    picture.Image = Bitmap.FromStream(stream);
                    vimagem = Bitmap.FromStream(stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Imagem Invalida \n" + ex.Message);
            }
            conexao.DesconectarBD();

        }

        private void cbbServico_Click(object sender, EventArgs e)
        {
            preencherCBB();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tela_recibo trela = new tela_recibo();
            trela.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                tela_visualisa tela = new tela_visualisa();
                tela.Show();
                RetornarImagem(tela.pictureBox1, vimagem1, Variaveis_globais.id_ocorrencia);

            }
            catch
            {
                MessageBox.Show("Não há imagem anexada", "Null", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
