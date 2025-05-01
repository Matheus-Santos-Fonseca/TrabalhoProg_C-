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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabalho
{
    public partial class Form_cadastro : Form
    {
        private bool isPasswordVisible = false;
        public MySqlConnection bdConn = null;
        public Form_cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            senha.UseSystemPasswordChar = !isPasswordVisible;
                
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            senha_confirm.UseSystemPasswordChar = !isPasswordVisible;
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            bdConn = new MySqlConnection("server=localhost;database=Banco_cadastro;uid=root;pwd=1234;charset=utf8mb4");
            bdConn.Open();
            string usuarios = usuario.Text;
            string senhas = senha.Text;
            string senhas_confirm = senha_confirm.Text;

            if (string.IsNullOrWhiteSpace(usuarios) || string.IsNullOrWhiteSpace(senhas) || string.IsNullOrWhiteSpace(senhas_confirm))
            {
                MessageBox.Show("Um ou mais campos não foram preenchidos", "Erro");
                return;
            }
            if (senhas == senhas_confirm)
            {
                string sql = "INSERT INTO Usuarios (NomeUsuario, Senha) VALUES (@Usuario, @Senha)";
                MySqlCommand Comm = new MySqlCommand(sql, bdConn);

                Comm.CommandType = CommandType.Text;
                Comm.Parameters.AddWithValue("@Usuario", usuario.Text);
                Comm.Parameters.AddWithValue("@Senha", senha.Text);
                Comm.ExecuteNonQuery();

                usuario.Clear();
                senha.Clear();
                senha_confirm.Clear();
                MessageBox.Show("Cadastrado com Sucesso!!");
                bdConn.Close();
            }
            else
            {
                MessageBox.Show("As senhas não coincidem. Tente novamente.", "Erro");
                usuario.Clear();
                senha.Clear();
                senha_confirm.Clear();
            }

            /*
            hashar senha
            byte[] salt;
            using (SHA256 sha256 = SHA256.Create())
            {
            Combina a senha com o coiso
            string saltedPassword = password + salt;
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
            return Convert.ToBase64String(bytes);
            
            gera o coiso
            private string GenerateSalt()
            {
            byte[] saltBytes = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
              rng.GetBytes(saltBytes);
            }
             return Convert.ToBase64String(saltBytes);
            }
            salva no banco
            string salt = GenerateSalt();
            string hashedPassword = HashPassword(password, salt);
            Comm.Parameters.AddWithValue("@Senha", hashedPassword);
            Comm.Parameters.AddWithValue("@Salt", salt);

            compara
            private bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
            {
             string hashedEnteredPassword = HashPassword(enteredPassword, storedSalt);
             return hashedEnteredPassword == storedHash;
            }
            */

        }

        
    }
}
