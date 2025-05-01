using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
            foreach (Control controle in this.Controls)
            {
                // Verifica se o controle é do tipo MdiClient (o espaço de fundo do MDI)
                if (controle is MdiClient)
                {
                    controle.BackColor = Color.FromKnownColor(KnownColor.GradientInactiveCaption);// Define a cor de fundo do MDI
                }
            }
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Funcionario Cadastro_Funcionario = new Form_Funcionario();
            Cadastro_Funcionario.MdiParent = this;
            Cadastro_Funcionario.Show();
            
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Venda Produtos = new Form_Venda();
            Produtos.MdiParent = this;
            Produtos.Show();
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastrarAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_cadastro cd = new Form_cadastro();
            cd.MdiParent = this;
            cd.Show();
        }
    }
}
