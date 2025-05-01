namespace Trabalho
{
    partial class Form_Venda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGdados = new System.Windows.Forms.DataGridView();
            this.nome_produto = new System.Windows.Forms.TextBox();
            this.forma_pagamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.data_venda = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.preco_unitario = new System.Windows.Forms.TextBox();
            this.quantidade_vendida = new System.Windows.Forms.TextBox();
            this.mudar = new System.Windows.Forms.Button();
            this.Tirar = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.cadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGdados)).BeginInit();
            this.SuspendLayout();
            // 
            // DGdados
            // 
            this.DGdados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGdados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGdados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DGdados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGdados.Location = new System.Drawing.Point(648, 69);
            this.DGdados.Name = "DGdados";
            this.DGdados.Size = new System.Drawing.Size(618, 357);
            this.DGdados.TabIndex = 49;
            this.DGdados.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGdados_RowEnter);
            // 
            // nome_produto
            // 
            this.nome_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nome_produto.BackColor = System.Drawing.SystemColors.Window;
            this.nome_produto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nome_produto.Font = new System.Drawing.Font("Arial", 12F);
            this.nome_produto.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nome_produto.Location = new System.Drawing.Point(70, 69);
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.Size = new System.Drawing.Size(180, 19);
            this.nome_produto.TabIndex = 37;
            // 
            // forma_pagamento
            // 
            this.forma_pagamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forma_pagamento.BackColor = System.Drawing.SystemColors.Window;
            this.forma_pagamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forma_pagamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forma_pagamento.FormattingEnabled = true;
            this.forma_pagamento.Location = new System.Drawing.Point(418, 147);
            this.forma_pagamento.Name = "forma_pagamento";
            this.forma_pagamento.Size = new System.Drawing.Size(147, 26);
            this.forma_pagamento.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(414, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "Forma de Pagamento:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(66, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Quantidade Vendida:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(66, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nome Produto:";
            // 
            // data_venda
            // 
            this.data_venda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.data_venda.CustomFormat = "yyyy-M-dd";
            this.data_venda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_venda.Location = new System.Drawing.Point(418, 69);
            this.data_venda.Name = "data_venda";
            this.data_venda.Size = new System.Drawing.Size(147, 20);
            this.data_venda.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(414, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 56;
            this.label4.Text = "Data Venda:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(66, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 23);
            this.label5.TabIndex = 57;
            this.label5.Text = "Preço Unitário:";
            // 
            // preco_unitario
            // 
            this.preco_unitario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.preco_unitario.BackColor = System.Drawing.SystemColors.Window;
            this.preco_unitario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.preco_unitario.Font = new System.Drawing.Font("Arial", 12F);
            this.preco_unitario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.preco_unitario.Location = new System.Drawing.Point(70, 147);
            this.preco_unitario.Name = "preco_unitario";
            this.preco_unitario.Size = new System.Drawing.Size(180, 19);
            this.preco_unitario.TabIndex = 58;
            // 
            // quantidade_vendida
            // 
            this.quantidade_vendida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantidade_vendida.BackColor = System.Drawing.SystemColors.Window;
            this.quantidade_vendida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantidade_vendida.Font = new System.Drawing.Font("Arial", 12F);
            this.quantidade_vendida.ForeColor = System.Drawing.SystemColors.InfoText;
            this.quantidade_vendida.Location = new System.Drawing.Point(70, 220);
            this.quantidade_vendida.Name = "quantidade_vendida";
            this.quantidade_vendida.Size = new System.Drawing.Size(180, 19);
            this.quantidade_vendida.TabIndex = 59;
            // 
            // mudar
            // 
            this.mudar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mudar.BackColor = System.Drawing.SystemColors.Window;
            this.mudar.BackgroundImage = global::Trabalho.Properties.Resources.config;
            this.mudar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mudar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mudar.FlatAppearance.BorderSize = 0;
            this.mudar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mudar.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mudar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.mudar.Location = new System.Drawing.Point(441, 307);
            this.mudar.Name = "mudar";
            this.mudar.Size = new System.Drawing.Size(127, 39);
            this.mudar.TabIndex = 51;
            this.mudar.UseVisualStyleBackColor = false;
            this.mudar.Click += new System.EventHandler(this.mudar_Click);
            // 
            // Tirar
            // 
            this.Tirar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tirar.BackColor = System.Drawing.SystemColors.Window;
            this.Tirar.BackgroundImage = global::Trabalho.Properties.Resources.x;
            this.Tirar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Tirar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tirar.FlatAppearance.BorderSize = 0;
            this.Tirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tirar.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tirar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Tirar.Location = new System.Drawing.Point(231, 352);
            this.Tirar.Name = "Tirar";
            this.Tirar.Size = new System.Drawing.Size(127, 39);
            this.Tirar.TabIndex = 50;
            this.Tirar.UseVisualStyleBackColor = false;
            this.Tirar.Click += new System.EventHandler(this.Tirar_Click);
            // 
            // apagar
            // 
            this.apagar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apagar.BackColor = System.Drawing.SystemColors.Window;
            this.apagar.BackgroundImage = global::Trabalho.Properties.Resources.limpar;
            this.apagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apagar.FlatAppearance.BorderSize = 0;
            this.apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apagar.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.apagar.Location = new System.Drawing.Point(308, 307);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(127, 39);
            this.apagar.TabIndex = 48;
            this.apagar.UseVisualStyleBackColor = false;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // voltar
            // 
            this.voltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.voltar.BackColor = System.Drawing.SystemColors.Window;
            this.voltar.BackgroundImage = global::Trabalho.Properties.Resources.voltar;
            this.voltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar.FlatAppearance.BorderSize = 0;
            this.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltar.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.voltar.Location = new System.Drawing.Point(364, 352);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(127, 39);
            this.voltar.TabIndex = 47;
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // cadastrar
            // 
            this.cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cadastrar.BackColor = System.Drawing.SystemColors.Window;
            this.cadastrar.BackgroundImage = global::Trabalho.Properties.Resources.salvar;
            this.cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastrar.FlatAppearance.BorderSize = 0;
            this.cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrar.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cadastrar.Location = new System.Drawing.Point(175, 307);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(127, 39);
            this.cadastrar.TabIndex = 46;
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(808, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 60;
            this.label6.Text = "Buscar:";
            // 
            // buscar
            // 
            this.buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buscar.BackColor = System.Drawing.SystemColors.Window;
            this.buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.buscar.Font = new System.Drawing.Font("Arial", 12F);
            this.buscar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.buscar.Location = new System.Drawing.Point(901, 29);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(258, 19);
            this.buscar.TabIndex = 61;
            this.buscar.TextChanged += new System.EventHandler(this.buscar_TextChanged);
            // 
            // Form_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1266, 450);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantidade_vendida);
            this.Controls.Add(this.preco_unitario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.data_venda);
            this.Controls.Add(this.mudar);
            this.Controls.Add(this.Tirar);
            this.Controls.Add(this.DGdados);
            this.Controls.Add(this.nome_produto);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.forma_pagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form_Venda";
            this.Text = "Form_Venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGdados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button mudar;
        private System.Windows.Forms.Button Tirar;
        private System.Windows.Forms.DataGridView DGdados;
        private System.Windows.Forms.TextBox nome_produto;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.ComboBox forma_pagamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker data_venda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox preco_unitario;
        private System.Windows.Forms.TextBox quantidade_vendida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox buscar;
    }
}