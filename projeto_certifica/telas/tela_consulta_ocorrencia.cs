using MySql.Data.MySqlClient;
using projeto_certifica.Controlador;
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
    public partial class tela_consulta_ocorrencia : Form
    {
        public tela_consulta_ocorrencia()
        {
            InitializeComponent();
        }


        string area = "";
        private Form objForm;
        tela_principal principal = new tela_principal();
        Form1 login = new Form1();
        public string id_ocorrencia;
        Lista_DataGrids listar = new Lista_DataGrids();
        Conexao conexao = new Conexao();
        Image vimagem1;
        Image vimagem2;
        Image vimagem3;
        Image vimagem4;

        string qt1="";
        string qt2 = "";
        string qt3 = "";
        string qt4 = "";
        string qt5 = "";
        string qt6 = "";
        string qt7 = "";
        string qt8 = "";

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tela_consulta_ocorrencia_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = listar.listarTodos();
            dataGridView1.DataSource = ds.Tables[1];
            dataGridView1.Columns[0].HeaderText = "N° ocorrencia";
            dataGridView1.Columns[1].HeaderText = "Usuario";
            dataGridView1.Columns[2].HeaderText = "Status";
            dataGridView1.Columns[3].HeaderText = "Cpf";
            dataGridView1.Columns[4].HeaderText = "placa";
            dataGridView1.Refresh();
        }

         public DataSet ListarId()
         {
            DataSet ds = new DataSet();
            MySqlDataAdapter da;
            da = new MySqlDataAdapter("select * from tb_ocorrencia  where id_ocorrencia like '%" + txtIdOcorrencia.Text + "%'", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;
         }

        public DataSet ListarPlaca()
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da;
            da = new MySqlDataAdapter("select * from tb_ocorrencia  where placa like '%" + txtPlaca.Text + "%'", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;
        }

        public DataSet ListarCpf()
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da;
            da = new MySqlDataAdapter("select * from tb_ocorrencia  where cpf_proprietario like '%" + mskCpf.Text + "%'", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;
        }

        public DataSet ListarStatus()
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da;
            da = new MySqlDataAdapter("select * from tb_ocorrencia  where status_ocorrencia like '%" + cbbStatus.Text + "%'", conexao.ConectarBD());
            da.Fill(ds);
            conexao.DesconectarBD();
            return ds;
        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_ocorrencia = (dataGridView1.Rows[e.RowIndex].Cells["id_ocorrencia"].Value).ToString();
            Variaveis_globais.id_ocorrencia = id_ocorrencia;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string status;  
            MySqlDataReader dr;

            Conexao con = new Conexao();
            MySqlCommand cmd = new MySqlCommand("select * from tb_ocorrencia where id_ocorrencia=@id", con.ConectarBD());
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id_ocorrencia;
            dr = cmd.ExecuteReader();
            try
            {

                tela_consulta_form tela = new tela_consulta_form();
                tela.Show();
                tela.pictureBox1.Image = null;
                tela.pictureBox2.Image = null;
                tela.pictureBox3.Image = null;
                tela.pictureBox4.Image = null;


                if (dr.HasRows == false)
                {
                    MessageBox.Show("Não houve nenhuma ocorrência com este código !");
                }
                else
                {
                    while (dr.Read())
                    {
                        status = dr[2].ToString();
                        tela.txt_nm_ocorrencia.Text = dr[0].ToString();

                        
                        tela.lbl_status.Text = dr[2].ToString();

                        tela.txt_nome_prop.Text = dr[3].ToString();
                        tela.msk_cpf.Text = dr[4].ToString();
                        tela.msk_celular.Text = dr[5].ToString();
                        tela.txt_endereco.Text = dr[6].ToString();
                        tela.txt_rg.Text = dr[7].ToString();
                        tela.txt_cnh.Text = dr[8].ToString();
                        tela.txt_renavan.Text = dr[9].ToString();
                        tela.txt_modelo.Text = dr[10].ToString();
                        tela.txt_placa.Text = dr[11].ToString();
                        tela.txt_cor.Text = dr[12].ToString();
                        tela.dtp_ano.Text = dr[13].ToString();
                        tela.txt_descricao.Text = dr[14].ToString();
                        tela.dtp_data_entrada.Text = dr[15].ToString();
                        tela.msk_hora_entrada.Text = dr[16].ToString();

                        area = dr[17].ToString();
                        if (area == "1")
                        {
                            tela.radioButton1.Checked = true;
                        }
                        else if (area == "2")
                        {
                            tela.radioButton1.Checked = true;
                        }
                        else if (area == "3")
                        {
                            tela.radioButton3.Checked = true;
                        }
                        else if (area == "4")
                        {
                            tela.radioButton4.Checked = true;
                        }
                        else if (area == "5")
                        {
                            tela.radioButton5.Checked = true;
                        }
                        else if (area == "6")
                        {
                            tela.radioButton6.Checked = true;
                        }
                        else if (area == "7")
                        {
                            tela.radioButton7.Checked = true;
                        }

                        RetornarImagem(tela.pictureBox1, vimagem1, id_ocorrencia);
                        RetornarImagem2(tela.pictureBox2, vimagem2, id_ocorrencia);
                        RetornarImagem3(tela.pictureBox3, vimagem3, id_ocorrencia);
                        RetornarImagem4(tela.pictureBox4, vimagem4, id_ocorrencia);


                        qt1 = dr[22].ToString();
                        if (qt1 == "Sim")
                        {
                            tela.rdb1q1.Checked = true;
                        }
                        else if (qt1 == "Não")
                        {
                            tela.rdb2q1.Checked = true;
                        }

                        qt2 = dr[23].ToString();
                        if (qt2 == "Sim")
                        {
                            tela.rdb1q2.Checked = true;
                        }
                        else if (qt2 == "Não")
                        {
                            tela.rdb2q2.Checked = true;
                        }
                        qt3 = dr[24].ToString();
                        if (qt3 == "Sim")
                        {
                            tela.rdb1q3.Checked = true;
                        }
                        else if (qt3 == "Não")
                        {
                            tela.rdb2q3.Checked = true;
                        }
                        qt4 = dr[25].ToString();
                        if (qt4 == "Sim")
                        {
                            tela.rdb1q4.Checked = true;
                        }
                        else if (qt4 == "Não")
                        {
                            tela.rdb2q4.Checked = true;
                        }
                        qt5 = dr[26].ToString();
                        if (qt5 == "Sim")
                        {
                            tela.rdb1q5.Checked = true;
                        }
                        else if (qt5 == "Não")
                        {
                            tela.rdb2q5.Checked = true;
                        }

                        qt6 = dr[27].ToString();
                        if (qt6 == "Sim")
                        {
                            tela.rdb1q6.Checked = true;
                        }
                        else if (qt6 == "Não")
                        {
                            tela.rdb2q6.Checked = true;
                        }
                        qt7 = dr[28].ToString();
                        if (qt7 == "Sim")
                        {
                            tela.rdb1q7.Checked = true;
                        }
                        else if (qt7 == "Não")
                        {
                            tela.rdb2q7.Checked = true;
                        }
                        qt8 = dr[29].ToString();
                        if (qt8 == "Sim")
                        {
                            tela.rdb1q8.Checked = true;
                        }
                        else if (qt8 == "Não")
                        {
                            tela.rdb2q8.Checked = true;
                        }


                    }

                    con.DesconectarBD();
                    con.ConectarBD();
                    con.DesconectarBD();
                }
            }

            catch
            {


            }
        }

        public void RetornarImagem(PictureBox picture, Image vimagem, string id)
        {
            try
            {         
                MySqlCommand cmdSelect = new MySqlCommand("select img_entrada from tb_ocorrencia where id_ocorrencia=@ID", conexao.ConectarBD());
                cmdSelect.Parameters.Add("@ID", MySqlDbType.VarChar).Value =id;
                DataSet ds = new DataSet();
                MySqlDataAdapter sqlda = new MySqlDataAdapter(cmdSelect);
                sqlda.Fill(ds, "tb_ocorrencia");

                using (var stream = new System.IO.MemoryStream((byte[])ds.Tables["tb_ocorrencia"].Rows[0]["img_entrada"]))
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
        public void RetornarImagem2(PictureBox picture, Image vimagem, string id)
        {

          


            try
            {

                MySqlCommand cmdSelect = new MySqlCommand("select img_saida from tb_ocorrencia where id_ocorrencia=@ID", conexao.ConectarBD());
                cmdSelect.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
                DataSet ds = new DataSet();
                MySqlDataAdapter sqlda = new MySqlDataAdapter(cmdSelect);
                sqlda.Fill(ds, "tb_ocorrencia");


                using (var stream = new System.IO.MemoryStream((byte[])ds.Tables["tb_ocorrencia"].Rows[0]["img_saida"]))
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
        public void RetornarImagem3(PictureBox picture, Image vimagem, string id)
        {




            try
            {

                MySqlCommand cmdSelect = new MySqlCommand("select img_avaria from tb_ocorrencia where id_ocorrencia=@ID", conexao.ConectarBD());
                cmdSelect.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
                DataSet ds = new DataSet();
                MySqlDataAdapter sqlda = new MySqlDataAdapter(cmdSelect);
                sqlda.Fill(ds, "tb_ocorrencia");


                using (var stream = new System.IO.MemoryStream((byte[])ds.Tables["tb_ocorrencia"].Rows[0]["img_avaria"]))
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
        public void RetornarImagem4(PictureBox picture, Image vimagem, string id)
        {

            try
            {

                MySqlCommand cmdSelect = new MySqlCommand("select img_ocorrencia from tb_ocorrencia where id_ocorrencia=@ID", conexao.ConectarBD());
                cmdSelect.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
                DataSet ds = new DataSet();
                MySqlDataAdapter sqlda = new MySqlDataAdapter(cmdSelect);
                sqlda.Fill(ds, "tb_ocorrencia");


                using (var stream = new System.IO.MemoryStream((byte[])ds.Tables["tb_ocorrencia"].Rows[0]["img_ocorrencia"]))
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

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = listar.listarTodos();
            dataGridView1.DataSource = ds.Tables[1];
            dataGridView1.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DataSet ds = new DataSet();
                ds = ListarId();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
            }
            if (radioButton2.Checked)
            {
                DataSet ds = new DataSet();
                ds = ListarPlaca();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
            }
            if (radioButton3.Checked)
            {
                DataSet ds = new DataSet();
                ds = ListarCpf();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
            }
            if (radioButton4.Checked)
            {
                DataSet ds = new DataSet();
                ds = ListarStatus();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtIdOcorrencia.Enabled = false;
            txtPlaca.Enabled = false;
            mskCpf.Enabled = true;
            cbbStatus.Enabled = false;
            cbbStatus.Text = "";
            txtIdOcorrencia.Clear();
            txtPlaca.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtIdOcorrencia.Enabled = true;
            txtPlaca.Enabled = false;
            mskCpf.Enabled = false;
            cbbStatus.Enabled = false;
            txtPlaca.Clear();
            mskCpf.Clear();
            cbbStatus.Text ="";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtIdOcorrencia.Enabled = false;
            txtPlaca.Enabled = true;
            mskCpf.Enabled = false;
            cbbStatus.Enabled = false;
            mskCpf.Clear();
            cbbStatus.Text = "";
            txtIdOcorrencia.Clear();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtIdOcorrencia.Enabled = false;
            txtPlaca.Enabled = false;
            mskCpf.Enabled = false;
            cbbStatus.Enabled = true;
            mskCpf.Clear();
            txtIdOcorrencia.Clear();
            txtPlaca.Clear();
        }

        private void atrelarOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
              MySqlDataReader dr;
              Conexao con = new Conexao();
              MySqlCommand cmd = new MySqlCommand("select * from tb_orcamento where id_ocorrencia=@id", con.ConectarBD());
              cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id_ocorrencia;
             
              dr = cmd.ExecuteReader();
              if (dr.HasRows)
              {
                tela_consulta_orcamento tela = new tela_consulta_orcamento();
                tela.Show();
                Variaveis_globais.id_ocorrencia = id_ocorrencia;
                 
              }
              else
              {
                  MessageBox.Show("Esta ocorrência não possui orçamento. \n Para adicionar dê dois clicks na ocorrência desejada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
              }
          }
        }
    }




