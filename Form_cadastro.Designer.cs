namespace Trabalho
{
    partial class Form_cadastro
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
            this.senha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ver_senha = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.cadastrar = new System.Windows.Forms.Button();
            this.senha_confirm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // senha
            // 
            this.senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.senha.BackColor = System.Drawing.SystemColors.Window;
            this.senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senha.Font = new System.Drawing.Font("Arial", 12F);
            this.senha.ForeColor = System.Drawing.SystemColors.InfoText;
            this.senha.Location = new System.Drawing.Point(209, 144);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(304, 19);
            this.senha.TabIndex = 73;
            this.senha.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(335, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 72;
            this.label5.Text = "Senha";
            // 
            // usuario
            // 
            this.usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usuario.BackColor = System.Drawing.SystemColors.Window;
            this.usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuario.Font = new System.Drawing.Font("Arial", 12F);
            this.usuario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.usuario.Location = new System.Drawing.Point(209, 94);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(304, 19);
            this.usuario.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(326, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 60;
            this.label1.Text = "Usuário";
            // 
            // ver_senha
            // 
            this.ver_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ver_senha.BackColor = System.Drawing.SystemColors.Window;
            this.ver_senha.BackgroundImage = global::Trabalho.Properties.Resources.senha_do_olho;
            this.ver_senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ver_senha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ver_senha.FlatAppearance.BorderSize = 0;
            this.ver_senha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ver_senha.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ver_senha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ver_senha.Location = new System.Drawing.Point(478, 144);
            this.ver_senha.Name = "ver_senha";
            this.ver_senha.Size = new System.Drawing.Size(35, 19);
            this.ver_senha.TabIndex = 74;
            this.ver_senha.UseVisualStyleBackColor = false;
            this.ver_senha.Click += new System.EventHandler(this.button1_Click);
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
            this.voltar.Location = new System.Drawing.Point(386, 264);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(127, 39);
            this.voltar.TabIndex = 66;
            this.voltar.UseVisualStyleBackColor = false;
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
            this.cadastrar.Location = new System.Drawing.Point(209, 264);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(127, 39);
            this.cadastrar.TabIndex = 65;
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // senha_confirm
            // 
            this.senha_confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.senha_confirm.BackColor = System.Drawing.SystemColors.Window;
            this.senha_confirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senha_confirm.Font = new System.Drawing.Font("Arial", 12F);
            this.senha_confirm.ForeColor = System.Drawing.SystemColors.InfoText;
            this.senha_confirm.Location = new System.Drawing.Point(209, 203);
            this.senha_confirm.Name = "senha_confirm";
            this.senha_confirm.Size = new System.Drawing.Size(304, 19);
            this.senha_confirm.TabIndex = 75;
            this.senha_confirm.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(267, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 23);
            this.label2.TabIndex = 76;
            this.label2.Text = "Confirme sua senha";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.BackgroundImage = global::Trabalho.Properties.Resources.senha_do_olho;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Location = new System.Drawing.Point(478, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 19);
            this.button1.TabIndex = 77;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 409);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.senha_confirm);
            this.Controls.Add(this.ver_senha);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.label1);
            this.Name = "Form_cadastro";
            this.Text = "Form_cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ver_senha;
        private System.Windows.Forms.TextBox senha_confirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}