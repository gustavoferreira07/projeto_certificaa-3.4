using AForge.Video.DirectShow;
using projeto_certifica.telas;
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
using AForge.Video;
using projeto_certifica.Repositorio;
using projeto_certifica.Controlador;

namespace projeto_certifica.telas
{
    public partial class tela_gerar_ocorrencia : Form
    {

        public long tamanhoArquivoImagem = 0;
        public byte[] vetorImagens1;
        public byte[] vetorImagens2;
        public byte[] vetorImagens3;
        public byte[] vetorImagens4;
        private FilterInfoCollection f;
        private VideoCaptureDevice c;
        AForge.Video.DirectShow.FilterInfoCollection video = new AForge.Video.DirectShow.FilterInfoCollection(AForge.Video.DirectShow.FilterCategory.VideoInputDevice);
        tela_principal prin = new tela_principal();
        Ocorrencia ocorrencia;
        Form1 login = new Form1();
        Salvar_ocorrencia salvarOcorrencia = new Salvar_ocorrencia();
        public string id_user;


        public tela_gerar_ocorrencia()
        {
            InitializeComponent();
        }

        private void tela_gerar_ocorrencia_Load(object sender, EventArgs e)
        {

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

                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregaImagem1(pictureBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarregaImagem2(pictureBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarregaImagem3(pictureBox3);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            CarregaImagem4(pictureBox4);
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

        private void button4_Click(object sender, EventArgs e)
        {

            
                ocorrencia = new Ocorrencia();


                ocorrencia.Nm_ocorrencia = txt_nm_ocorrencia.Text;
                ocorrencia.Nm_usuario = Variaveis_globais.usuario;
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
                ocorrencia.Img_entrada = vetorImagens1;
                ocorrencia.Img_saida = vetorImagens2;
                ocorrencia.Img_avaria = vetorImagens3;
                ocorrencia.Img_ocorrencia = vetorImagens4;

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
                    ocorrencia.Questao7 = "não";
                }
                if (rdb1q8.Checked)
                {
                    ocorrencia.Questao8 = "Sim";
                }
                if (rdb2q8.Checked)
                {
                    ocorrencia.Questao8 = "Não";
                }
                try

                {

                    salvarOcorrencia.salvar_Ocorrencia(ocorrencia);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {

            }

        private void lbl_status_Click(object sender, EventArgs e)
        {

        }
    }
    }
