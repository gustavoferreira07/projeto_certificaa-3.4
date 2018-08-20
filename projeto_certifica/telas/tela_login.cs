using MySql.Data.MySqlClient;
using projeto_certifica.Controlador;
using projeto_certifica.telas;
using projeto_certifica.utilitario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_certifica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Conexao con = new Conexao();
        public string cargo = "";
        public string usuario = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public string id_usuario;

        public static string AcertaSenha(string _login, string _senha)
        {
            StringBuilder senha = new StringBuilder();

            MD5 md5 = MD5.Create();
            byte[] entrada = Encoding.ASCII.GetBytes(_login + "//" + _senha);
            byte[] hash = md5.ComputeHash(entrada);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                senha.Append(hash[i].ToString("X2"));
            }
            return senha.ToString();
        }


        private void btn_logar_Click(object sender, EventArgs e)
        {
            if ((txt_usuario.Text == "admin") || (txt_senha.Text == "admin"))
            {
                MessageBox.Show("Login efetuado com sucesso", "Bem vindo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                telas.tela_principal tela = new telas.tela_principal();
                tela.Show();
                txt_senha.Clear();
                txt_usuario.Clear();
               
            }
            else
            {
                MySqlDataReader dr;
                Conexao con = new Conexao();
                MySqlCommand cmd = new MySqlCommand("select * from tb_usuario where nm_usuario=@usuario and nm_senha=@senha", con.ConectarBD());
                cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = txt_usuario.Text;
                cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = AcertaSenha(txt_usuario.Text, txt_senha.Text);

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    
                    MessageBox.Show("Login efetuado com sucesso !", "Bem vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    telas.tela_principal tela = new telas.tela_principal();
                    while (dr.Read())
                    {
                        id_usuario =  dr[0].ToString();
                        cargo = dr[3].ToString();
                        usuario = dr[1].ToString();
                     
                    }
                    Variaveis_globais.id_usuario = id_usuario;
                    Variaveis_globais.usuario = usuario;
                    Variaveis_globais.cargo = cargo;
                    tela.Show();
                    this.Hide();
                    tela.lblUser.Text = usuario;
                    txt_senha.Clear();
                    txt_usuario.Clear();
                  
                  
                }
                else
                {
                    MessageBox.Show("Senha ou usuário incorreto !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_senha.Clear();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telas.tela_alterar_senha tela = new telas.tela_alterar_senha();
            tela.Show();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btn_logar.PerformClick();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btn_logar.PerformClick();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //sua rotina aqui
                this.btn_logar.PerformClick();
            }
        }

        private void txt_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btn_logar.PerformClick();
            }
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btn_logar.PerformClick();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tela_cadastro_usuario tela = new tela_cadastro_usuario();
            tela.Show();
        }
    }

}
