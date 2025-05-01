using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabalho
{
    public partial class Form_Venda : Form
    {
        public Form_Venda()
        {
            InitializeComponent();
        }

        private DataTable dt = new DataTable();

        public MySqlConnection bdConn = null;
        public int Cod = 0;

        private void Gravar()
        {
            bdConn = new MySqlConnection("server=localhost;database=Banco_cadastro;uid=root;pwd=1234;charset=utf8mb4");
            bdConn.Open();

            string sql = string.Empty;

            if (Cod == 0)
            {
                sql = "insert into Tbl_Vendas (data_venda, nome_produto, quantidade_produto, preço_unitario, preço_total, forma_de_pagamento) values (@data_venda, @nome_produto, @quantidade_produto, @preço_unitario, @preço_total, @forma_de_pagamento)";
            }
            else
            {
                sql = "update Tbl_Vendas set data_venda=@data_venda, nome_produto=@nome_produto, quantidade_produto=@quantidade_produto, preço_unitario=@preço_unitario, preço_total=@preço_total, forma_de_pagamento=@forma_de_pagamento where codigo_venda=@codigo_venda";
            }

            MySqlCommand Comm = new MySqlCommand(sql, bdConn);

            int preco_total = Convert.ToInt32(quantidade_vendida.Text) * Convert.ToInt32(preco_unitario.Text);

            Comm.CommandType = CommandType.Text;
            Comm.Parameters.Add("@data_venda", MySqlDbType.VarChar).Value = data_venda.Text;
            Comm.Parameters.Add("@nome_produto", MySqlDbType.VarChar).Value = nome_produto.Text;
            Comm.Parameters.Add("@quantidade_produto", MySqlDbType.VarChar).Value = quantidade_vendida.Text;
            Comm.Parameters.Add("@preço_unitario", MySqlDbType.VarChar).Value = preco_unitario.Text;
            Comm.Parameters.Add("@preço_total", MySqlDbType.VarChar).Value = preco_total;
            Comm.Parameters.Add("@forma_de_pagamento", MySqlDbType.VarChar).Value = forma_pagamento.Text;

            if (Cod != 0)
            {
                Comm.Parameters.Add("@codigo_venda", MySqlDbType.Int32).Value = Cod;
                Cod = 0;
            }

            Comm.ExecuteNonQuery();
            MessageBox.Show("As informações foram salvas !!");
        }
        private void CarregaGrid()
        {
            bdConn = new MySqlConnection("server=localhost;database=Banco_cadastro;uid=root;pwd=1234;charset=utf8mb4");
            bdConn.Open();

            string sql = "select codigo_venda, data_venda, nome_produto, quantidade_produto, preço_unitario, preço_total, forma_de_pagamento from Tbl_Vendas order by codigo_venda";

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

            string sql = "select forma_de_pagamento from Tbl_FormadePagamento";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, bdConn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                forma_pagamento.Items.Add(dt.Rows[i]["forma_de_pagamento"]);
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
                data_venda.Text = DGdados.Rows[indice].Cells[1].Value.ToString();
                nome_produto.Text = DGdados.Rows[indice].Cells[2].Value.ToString();
                quantidade_vendida.Text = DGdados.Rows[indice].Cells[3].Value.ToString();
                preco_unitario.Text = DGdados.Rows[indice].Cells[4].Value.ToString();
                forma_pagamento.Text = DGdados.Rows[indice].Cells[6].Value.ToString();
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
            int rowIndex = DGdados.SelectedCells[0].RowIndex;
            var valor = DGdados.Rows[rowIndex].Cells["codigo_venda"].Value;
            if (DGdados.SelectedCells.Count > 0)
            {
                string sql = "DELETE FROM Tbl_Vendas WHERE codigo_venda = @codigo_venda";
                MySqlCommand Comm = new MySqlCommand(sql, bdConn);
                Comm.Parameters.Add("@codigo_venda", MySqlDbType.Int32).Value = Convert.ToInt32(valor);
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
            nome_produto.Clear();
            quantidade_vendida.Clear();
            preco_unitario.Clear();
            forma_pagamento.Text = string.Empty;
            nome_produto.Focus();
        }

        //Sair
        private void Sair()
        {
            if (MessageBox.Show("Deseja Realmente sair do Programa?", "Fechando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form_Venda_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            CarregaComboBox();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Gravar();
            CarregaGrid();
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void mudar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void Tirar_Click(object sender, EventArgs e)
        {
            Excluir();
            CarregaGrid();
        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", "nome_produto", buscar.Text);
        }
        private void voltar_Click(object sender, EventArgs e)
        {
            Sair();
        }

    }
}
