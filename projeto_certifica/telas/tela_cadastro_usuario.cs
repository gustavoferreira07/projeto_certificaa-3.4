using projeto_certifica.Controlador;
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

namespace projeto_certifica.telas
{
    public partial class tela_cadastro_usuario : Form
    {
        public tela_cadastro_usuario()
        {
            InitializeComponent();
        }

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


        private void button1_Click(object sender, EventArgs e)
        {
            if ((txt_usuario.Text == "") || (txt_senha.Text == "") || (txtSenha2.Text == "") || (cbbCargo.Text == "") || (txt_senha.Text != txtSenha2.Text))
            {
                MessageBox.Show("Preencha todos os campos corretamente!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else
            {
           
                Usuario usuario = new Usuario();
                SalvarUsuario salvar = new SalvarUsuario();

                usuario.User = txt_usuario.Text;
                usuario.Senha = AcertaSenha(txt_usuario.Text, txt_senha.Text);
                usuario.Cargo = cbbCargo.Text;

                salvar.salvarUsuario(usuario);
                txt_usuario.Clear();
                txt_senha.Clear();
                txtSenha2.Clear();
                cbbCargo.Text = "";
                txt_usuario.Focus();
                this.Close();
            }
        }

        private void tela_cadastro_usuario_Load(object sender, EventArgs e)
        {

        }

        private void txtSenha2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

