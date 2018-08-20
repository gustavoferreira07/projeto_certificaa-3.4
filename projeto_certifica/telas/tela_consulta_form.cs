using AForge.Video.DirectShow;
using MySql.Data.MySqlClient;
using projeto_certifica.Controlador;
using projeto_certifica.Repositorio;
using projeto_certifica.utilitario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_certifica.telas
{
    public partial class tela_consulta_form : Form
    {
        public tela_consulta_form()
        {
            InitializeComponent();
        }

        Conexao conexao = new Conexao();
        Ocorrencia ocorrencia;
        Salva_edit salva = new Salva_edit();
       
       
        public long tamanhoArquivoImagem = 0;
        public byte[] vetorImagens1;
        public byte[] vetorImagen1;
        public byte[] vetorImagens2;
        public byte[] vetorImagens3;
        public byte[] vetorImagens4;
        private FilterInfoCollection f;
        private VideoCaptureDevice c;
        AForge.Video.DirectShow.FilterInfoCollection video = new AForge.Video.DirectShow.FilterInfoCollection(AForge.Video.DirectShow.FilterCategory.VideoInputDevice);

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            tela_visualisa tela = new tela_visualisa();
            tela.Show();
            tela.pictureBox1.Image = pictureBox1.Image;
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            tela_visualisa tela = new tela_visualisa();
            tela.Show();
            tela.pictureBox1.Image = pictureBox2.Image;
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            tela_visualisa tela = new tela_visualisa();
            tela.Show();
            tela.pictureBox1.Image = pictureBox3.Image;
        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            tela_visualisa tela = new tela_visualisa();
            tela.Show();
            tela.pictureBox1.Image = pictureBox4.Image;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Deseja salvar as alterações feitas?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogo == DialogResult.Yes)
            {
                    Historico historico = new Historico();
                    ocorrencia = new Ocorrencia();
                    ocorrencia.Status = lbl_status.Text;
                    ocorrencia.Nome_proprietario = txt_nome_prop.Text;
                    ocorrencia.Cpf = msk_cpf.Text;
                    ocorrencia.Celular = msk_celular.Text;
                    ocorrencia.Endereco = txt_endereco.Text;
                    ocorrencia.Rg = txt_rg.Text;
                    ocorrencia.Cnh = txt_cnh.Text;
                    ocorrencia.Renavan = txt_renavan.Text;
                    ocorrencia.Modelo = txt_modelo.Text;
                    ocorrencia.Placa = txt_placa.Text;
                    ocorrencia.Cor = txt_cor.Text;
                    ocorrencia.Ano = dtp_ano.Text;
                    ocorrencia.Descricao = txt_descricao.Text;
                    ocorrencia.Data_entrada = dtp_data_entrada.Text;
                    ocorrencia.Hora_entrada = msk_hora_entrada.Text;
                    if (radioButton1.Checked)
                    {
                        ocorrencia.Area = "1";
                    }
                    else if (radioButton2.Checked)
                    {
                        ocorrencia.Area = "2";
                    }
                    else if (radioButton3.Checked)
                    {
                        ocorrencia.Area = "3";
                    }
                    else if (radioButton4.Checked)
                    {
                        ocorrencia.Area = "4";
                    }
                    else if (radioButton5.Checked)
                    {
                        ocorrencia.Area = "5";
                    }
                    else if (radioButton6.Checked)
                    {
                        ocorrencia.Area = "6";
                    }
                    if (radioButton7.Checked)
                    {
                        ocorrencia.Area = "7";
                    }
                   
                    if (rdb1q1.Checked)
                    {
                        ocorrencia.Questao1 = "Sim";
                    }
                    if (rdb2q1.Checked)
                    {
                        ocorrencia.Questao1 = "Não";
                    }
                    if (rdb1q2.Checked)
                    {
                        ocorrencia.Questao2 = "Sim";
                    }
                    if (rdb2q2.Checked)
                    {
                        ocorrencia.Questao2 = "Não";
                    }
                    if (rdb1q3.Checked)
                    {
                        ocorrencia.Questao3 = "Sim";
                    }
                    if (rdb2q3.Checked)
                    {
                        ocorrencia.Questao3 = "Não";
                    }
                    if (rdb1q4.Checked)
                    {
                        ocorrencia.Questao4 = "Sim";
                    }
                    if (rdb2q4.Checked)
                    {
                        ocorrencia.Questao4 = "Não";
                    }
                    if (rdb1q5.Checked)
                    {
                        ocorrencia.Questao5 = "Sim";
                    }
                    if (rdb2q5.Checked)
                    {
                        ocorrencia.Questao5 = "Não";
                    }
                    if (rdb1q6.Checked)
                    {
                        ocorrencia.Questao6 = "Sim";
                    }
                    if (rdb2q6.Checked)
                    {
                        ocorrencia.Questao6 = "Não";
                    }
                    if (rdb1q7.Checked)
                    {
                        ocorrencia.Questao7 = "Sim";
                    }
                    if (rdb2q7.Checked)
                    {
                        ocorrencia.Questao7 = "Não";
                    }
                    if (rdb1q8.Checked)
                    {
                        ocorrencia.Questao8 = "Sim";
                    }
                    if (rdb2q8.Checked)
                    {
                        ocorrencia.Questao8 = "Não";
                    }

                string data = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
                historico.Id_ocorrencia = txt_nm_ocorrencia.Text;
                historico.Nm_usuario = Variaveis_globais.usuario;
                historico.Data_edit = DateTime.Now;

                salva.salvarHistorico(historico);
                salva.salvaredit(ocorrencia, txt_nm_ocorrencia.Text);
                
                
            }
            else
            {

            }
        }

        public void SalvaFoto1()
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "update tb_ocorrencia set img_entrada= @foto where id_ocorrencia=@id";
            comando.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = vetorImagens1;
            comando.Parameters.Add("@id", MySqlDbType.VarChar).Value = Variaveis_globais.id_ocorrencia;
            comando.Connection = conexao.ConectarBD();
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("foto alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no update . \n Detalhes do erro: " + ex.Message);
            }
            conexao.DesconectarBD();
        }

        public void SalvaFoto2()
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "update tb_ocorrencia set img_saida= @foto where id_ocorrencia=@id";
            comando.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = vetorImagens2;
            comando.Parameters.Add("@id", MySqlDbType.VarChar).Value = Variaveis_globais.id_ocorrencia;
            comando.Connection = conexao.ConectarBD();
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("foto allterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no update . \n Detalhes do erro: " + ex.Message);
            }
            conexao.DesconectarBD();
        }

        public void SalvaFoto3()
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "update tb_ocorrencia set img_avaria= @foto where id_ocorrencia=@id";
            comando.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = vetorImagens3;
            comando.Parameters.Add("@id", MySqlDbType.VarChar).Value = Variaveis_globais.id_ocorrencia;
            comando.Connection = conexao.ConectarBD();
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("foto alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no update . \n Detalhes do erro: " + ex.Message);
            }
            conexao.DesconectarBD();
        }

        public void SalvaFoto4()
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "update tb_ocorrencia set img_ocorrencia= @foto where id_ocorrencia=@id";
            comando.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = vetorImagens4;
            comando.Parameters.Add("@id", MySqlDbType.VarChar).Value = Variaveis_globais.id_ocorrencia;
            comando.Connection = conexao.ConectarBD();
            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("foto alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no update . \n Detalhes do erro: " + ex.Message);
            }
            conexao.DesconectarBD();
        }


        public void CarregaImagem1(PictureBox picture)
        {

            try
            {

                opdcad.ShowDialog(this);

                string strFn = opdcad.FileName;

                if (string.IsNullOrEmpty(strFn))
                    return;

                picture.Image = Image.FromFile(strFn);
                FileInfo arqImagem = new FileInfo(strFn);
                tamanhoArquivoImagem = arqImagem.Length;
                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                vetorImagens1 = new byte[Convert.ToInt32(this.tamanhoArquivoImagem)];
                int iBytesRead = fs.Read(vetorImagens1, 0, Convert.ToInt32(this.tamanhoArquivoImagem));
                SalvaFoto1();
                fs.Close();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        public void CarregaImagem2(PictureBox picture)
        {

            try
            {

                opdcad.ShowDialog(this);

                string strFn = opdcad.FileName;

                if (string.IsNullOrEmpty(strFn))
                    return;

                picture.Image = Image.FromFile(strFn);
                FileInfo arqImagem = new FileInfo(strFn);
                tamanhoArquivoImagem = arqImagem.Length;
                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                vetorImagens2 = new byte[Convert.ToInt32(this.tamanhoArquivoImagem)];
                int iBytesRead = fs.Read(vetorImagens2, 0, Convert.ToInt32(this.tamanhoArquivoImagem));
                SalvaFoto2();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void CarregaImagem3(PictureBox picture)
        {

            try
            {

                opdcad.ShowDialog(this);

                string strFn = opdcad.FileName;

                if (string.IsNullOrEmpty(strFn))
                    return;

                picture.Image = Image.FromFile(strFn);
                FileInfo arqImagem = new FileInfo(strFn);
                tamanhoArquivoImagem = arqImagem.Length;
                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                vetorImagens3 = new byte[Convert.ToInt32(this.tamanhoArquivoImagem)];
                int iBytesRead = fs.Read(vetorImagens3, 0, Convert.ToInt32(this.tamanhoArquivoImagem));
                SalvaFoto3();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void CarregaImagem4(PictureBox picture)
        {

            try
            {

                opdcad.ShowDialog(this);

                string strFn = opdcad.FileName;

                if (string.IsNullOrEmpty(strFn))
                    return;

                picture.Image = Image.FromFile(strFn);
                FileInfo arqImagem = new FileInfo(strFn);
                tamanhoArquivoImagem = arqImagem.Length;
                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                vetorImagens4 = new byte[Convert.ToInt32(this.tamanhoArquivoImagem)];
                int iBytesRead = fs.Read(vetorImagens4, 0, Convert.ToInt32(this.tamanhoArquivoImagem));
                SalvaFoto4();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void RetornarImagem(PictureBox picture, Image vimagem, string id)
        {
            try
            {
                MySqlCommand cmdSelect = new MySqlCommand("select img_entrada from tb_ocorrencia where id_ocorrencia=@ID", conexao.ConectarBD());
                cmdSelect.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
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
             //   MessageBox.Show(" Imagem Invalida \n" + ex.Message);
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
              //  MessageBox.Show(" Imagem Invalida \n" + ex.Message);
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
            //    MessageBox.Show(" Imagem Invalida \n" + ex.Message);
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
             //   MessageBox.Show(" Imagem Invalida \n" + ex.Message);
            }
            conexao.DesconectarBD();
        }


        private void btn_anexar1_Click_1(object sender, EventArgs e)
        {
            CarregaImagem1(pictureBox1);
            
        }

        private void btn_anexar2_Click_1(object sender, EventArgs e)
        {
            CarregaImagem2(pictureBox2);
            
        }

        private void btn_anexar3_Click_1(object sender, EventArgs e)
        {
            CarregaImagem3(pictureBox3);
            
        }

        private void btn_anexar4_Click(object sender, EventArgs e)
        {
            CarregaImagem4(pictureBox4);
            
        }

        private void btn_anexar1_Click(object sender, EventArgs e)
        {
            CarregaImagem1(pictureBox1);
        }

        private void btn_anexar2_Click(object sender, EventArgs e)
        {
            CarregaImagem2(pictureBox2);
        }

        private void btn_anexar3_Click(object sender, EventArgs e)
        {
            CarregaImagem3(pictureBox3);
        }

        private void btn_anexar4_Click_1(object sender, EventArgs e)
        {
            CarregaImagem4(pictureBox4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tela_orcamento tela = new tela_orcamento();
            tela.Show();
            tela.lblNOcorrencia.Text = txt_nm_ocorrencia.Text;
            tela.btnSalvar.Visible = true;
        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btn_anexar1_Click_2(object sender, EventArgs e)
        {
            CarregaImagem1(pictureBox1);
        }

        private void btn_anexar2_Click_2(object sender, EventArgs e)
        {
            CarregaImagem2(pictureBox2);
        }

        private void btn_anexar3_Click_2(object sender, EventArgs e)
        {
            CarregaImagem3(pictureBox3);
        }

        private void btn_anexar4_Click_2(object sender, EventArgs e)
        {
            CarregaImagem4(pictureBox4);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox1.Image,20,50);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument2.PrinterSettings = printDialog1.PrinterSettings;
                printDocument2.Print();
            }
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox2.Image, 20, 50);
        }

        private void printDocument3_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox3.Image, 20, 50);
        }

        private void printDocument4_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox4.Image, 20, 50);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument3.PrinterSettings = printDialog1.PrinterSettings;
                printDocument3.Print();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDocument4.PrinterSettings = printDialog1.PrinterSettings;
                printDocument4.Print();
            }
        }

        private void tela_consulta_form_Load(object sender, EventArgs e)
        {

        }
    }
}
