using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class Login : Form
    {
        private bool isPasswordVisible = false;
        public MySqlConnection bdConn = null;
        public Login()
        {
            InitializeComponent();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
                bdConn = new MySqlConnection("server=localhost;database=Banco_cadastro;uid=root;pwd=1234;charset=utf8mb4");
                bdConn.Open();
                string usuarios = usuario.Text;
                string senhas = senha.Text;

                if (string.IsNullOrWhiteSpace(usuarios) || string.IsNullOrWhiteSpace(senhas))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Erro");
                    return;
                }
                string comparar_senha = "SELECT Senha FROM Usuarios WHERE NomeUsuario = @Usuario";
                MySqlCommand Comm = new MySqlCommand(comparar_senha, bdConn);
                Comm.Parameters.AddWithValue("@Usuario", usuarios);
                MySqlDataReader banco = Comm.ExecuteReader();
                if (banco.Read())  // Se encontrar o usuário
                {
                    string senha_banco = banco.GetString("Senha");
                    if (senhas == senha_banco)
                    {
                        Form_Principal formPrincipal = new Form_Principal();
                        formPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Senha ou Usuário incorretos", "Erro");
                        usuario.Clear();
                        senha.Clear();
                }
                }
                else
                {
                    MessageBox.Show("Senha ou Usuário incorretos", "Erro");
                    usuario.Clear();
                    senha.Clear();
            }

        }

        private void ver_senha_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            senha.UseSystemPasswordChar = !isPasswordVisible;
        }
    }
}
