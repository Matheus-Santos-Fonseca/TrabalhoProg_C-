using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Trabalho
{
    public partial class Form_Funcionario : Form
    {
        public Form_Funcionario()
        {
            InitializeComponent();
        }

        private DataTable dt = new DataTable();

        public MySqlConnection bdConn = null;
        public int Cod = 0;

        //Gravar
        private void Gravar()
        {
            bdConn = new MySqlConnection("server=localhost;database=Banco_cadastro;uid=root;pwd=1234;charset=utf8mb4");
            bdConn.Open();

            string sql = string.Empty;

            if (Cod == 0)
            {
                sql = "insert into Tbl_Funcionario (nome, celular, email, endereço, funcao) values (@nome, @celular, @email, @endereço, @funcao)";
            }
            else
            {
                sql = "update Tbl_Funcionario set nome=@nome, endereço=@endereço, celular=@celular, email=@email, funcao=@funcao where codigo=@codigo";
            }

            MySqlCommand Comm = new MySqlCommand(sql, bdConn);

            Comm.CommandType = CommandType.Text;
            Comm.Parameters.Add("@nome", MySqlDbType.VarChar).Value = textBox1.Text;
            Comm.Parameters.Add("@celular", MySqlDbType.VarChar).Value = textBox3.Text;
            Comm.Parameters.Add("@endereço", MySqlDbType.VarChar).Value = textBox2.Text;
            Comm.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBox4.Text;
            Comm.Parameters.Add("@funcao", MySqlDbType.VarChar).Value = comboBox1.Text;

            if (Cod != 0)
            {
                Comm.Parameters.Add("@Codigo", MySqlDbType.Int32).Value = Cod;
                Cod = 0;
            }

            Comm.ExecuteNonQuery();
            MessageBox.Show("As informações foram salvas !!");
        }

        private void CarregaGrid()
        {
            bdConn = new MySqlConnection("server=localhost;database=Banco_cadastro;uid=root;pwd=1234;charset=utf8mb4");
            bdConn.Open();

            string sql = "select codigo, nome, celular, endereço, email, funcao from Tbl_Funcionario order by codigo";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, bdConn);
           
            dt.Clear();
            da.Fill(dt);

            DGdados.DataSource = dt;

            foreach (DataGridViewColumn column in DGdados.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void CarregaComboBox()
        {
            bdConn = new MySqlConnection("server=localhost;database=Banco_cadastro;uid=root;pwd=1234;charset=utf8mb4");
            bdConn.Open();

            string sql = "select funcao from Tbl_Funcao";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, bdConn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["funcao"]);
            }

            bdConn.Close();
        }

        public int indice = 0;

        private void DGdados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        //Alterar
        private void Alterar()
        {
            if (DGdados.SelectedCells.Count > 0)
            {
                Cod = Convert.ToInt32(DGdados.Rows[indice].Cells[0].Value);
                textBox1.Text = DGdados.Rows[indice].Cells[1].Value.ToString();
                textBox2.Text = DGdados.Rows[indice].Cells[2].Value.ToString();
                textBox3.Text = DGdados.Rows[indice].Cells[3].Value.ToString();
                textBox4.Text = DGdados.Rows[indice].Cells[4].Value.ToString();
                comboBox1.Text = DGdados.Rows[indice].Cells[5].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecione uma célula da linha que você deseja alterar!!");
            }
        }

        //Excluir
        private void Excluir()
        {
            bdConn = new MySqlConnection("server=localhost;database=Banco_cadastro;uid=root;pwd=1234;charset=utf8mb4");
            bdConn.Open();

            string sql = string.Empty;

            if (DGdados.SelectedCells.Count > 0)
            {
                var cell = DGdados.SelectedCells[0];
                var valor = cell.Value;

                if (Cod == 0)
                {
                    sql = "delete from Tbl_Funcionario where codigo = @celula";
                }

                MySqlCommand Comm = new MySqlCommand(sql, bdConn);

                Comm.CommandType = CommandType.Text;
                Comm.Parameters.Add("@celula", MySqlDbType.VarChar).Value = valor;

                Comm.ExecuteNonQuery();
                MessageBox.Show("As informações foram apagadas!!");
            }
            else
            {
                MessageBox.Show("Selecione um código!!");
            }
        }

        private void Limpar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.Text = string.Empty;
            textBox1.Focus();
        }

        //Sair
        private void Sair()
        {
            if (MessageBox.Show("Deseja Realmente sair do Programa?", "Fechando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Gravar();
            CarregaGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Form_Funcionario_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            CarregaComboBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Excluir();
            CarregaGrid();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "nome", buscar.Text);
        }
    }
}
