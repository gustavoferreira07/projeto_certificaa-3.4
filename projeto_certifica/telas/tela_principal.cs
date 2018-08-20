using MySql.Data.MySqlClient;
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
    public partial class tela_principal : Form
    {
        public tela_principal()
        {
            InitializeComponent();
        }
        MySqlCommand cmd = new MySqlCommand();
        string sql = "";
        Conexao conexao = new Conexao();
        Form1 id = new Form1();
        public String login;
        private Form objForm;

        private void consultarStatusDeOcorrênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                objForm.Close();
                objForm = new tela_consulta_ocorrencia
                {
                    TopLevel = false,
                    //FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill

                };
                panel1.Controls.Add(objForm);
                objForm.Show();
            }
            catch
            {
                objForm = new tela_consulta_ocorrencia
                {
                    TopLevel = false,
                    //FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill

                };
                panel1.Controls.Add(objForm);
                objForm.Show();


            }
        }

        private void tela_principal_Load(object sender, EventArgs e)
        {

        }

       
        private void registrarNovaOcorrênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                objForm.Close();
                objForm = new tela_gerar_ocorrencia
                {
                    TopLevel = false,
                  //  FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill

                };
                panel1.Controls.Add(objForm);
                objForm.Show();
            }
            catch
            {
                objForm = new tela_gerar_ocorrencia
                {
                    TopLevel = false,
                    //FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill

                };
                panel1.Controls.Add(objForm);
                objForm.Show();


            }
        }

        private void registrarNovoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_cadastro_usuario tela = new tela_cadastro_usuario();
            tela.Show();
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Backup Files(*.bak)|*.bak";
                opf.FilterIndex = 0;

                if (opf.ShowDialog() == DialogResult.OK)

                {

                    sql = "Alter Database db_ocorrencia Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    sql += "use master restore database db_ocorrencia FROM Disk = '" + opf.FileName + "' WITH REPLACE;";
                    cmd = new MySqlCommand(sql, conexao.ConectarBD());
                    cmd.ExecuteNonQuery();
                    conexao.DesconectarBD();
                    MessageBox.Show("Restaurado com sucesso");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {


                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "DataBase Backup File(*.bak)|*.bak";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    sql = "USE master BACKUP DATABASE db_ocorrencias TO DISK ='" + sfd.FileName + "'";
                    cmd = new MySqlCommand(sql, conexao.ConectarBD());
                    cmd.ExecuteNonQuery();
                    conexao.DesconectarBD();
                    MessageBox.Show("Backup feito com sucesso");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Tente salvar o arquivo em outro local \n : " + ex.Message);
            }

            conexao.ChecarSetiveAberFecha();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100000350923523");
        }

        private void consultarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                objForm.Close();
                objForm = new tela_consulta_usuario
                {
                    TopLevel = false,
                    //  FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill

                };
                panel1.Controls.Add(objForm);
                objForm.Show();
            }
            catch
            {
                objForm = new tela_consulta_usuario
                {
                    TopLevel = false,
                    //FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill

                };
                panel1.Controls.Add(objForm);
                objForm.Show();


            }

        }

        private void validarOcorrênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tela_consulta_ocorrencia tela = new tela_consulta_ocorrencia();
            tela.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void validarOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void tela_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void históricoDeEdiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                objForm.Close();
                objForm = new tela_historico
                {
                    TopLevel = false,
                    //  FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill

                };
                panel1.Controls.Add(objForm);
                objForm.Show();
            }
            catch
            {
                objForm = new tela_historico
                {
                    TopLevel = false,
                    //FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill

                };
                panel1.Controls.Add(objForm);
                objForm.Show();


            }
        }

        private void listarTodosOrçamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                objForm.Close();
                objForm = new tela_consulta_todos_orcamentos
                {
                    TopLevel = false,
                    //  FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill

                };
                panel1.Controls.Add(objForm);
                objForm.Show();
            }
            catch
            {
                objForm = new tela_consulta_todos_orcamentos
                {
                    TopLevel = false,
                    //FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill

                };
                panel1.Controls.Add(objForm);
                objForm.Show();


            }
        }

        private void dadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ocorrênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
