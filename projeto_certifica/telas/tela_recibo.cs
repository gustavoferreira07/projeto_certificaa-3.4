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
    public partial class tela_recibo : Form
    {
        public tela_recibo()
        {
            InitializeComponent();
        }
        public long tamanhoArquivoImagem = 0;
        public byte[] vetorImagens1;

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
        private void button1_Click(object sender, EventArgs e)
        {
            CarregaImagem1(pictureBox1);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salva_orcamento salva = new Salva_orcamento();
            Orcamento orcamento = new Orcamento();

            orcamento.Img_recibo = vetorImagens1;

            salva.SalvaRecibo(orcamento);


        }
    }
}
