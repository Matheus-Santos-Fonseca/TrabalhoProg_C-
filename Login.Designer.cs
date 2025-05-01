namespace Trabalho
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.entrar = new System.Windows.Forms.Button();
            this.ver_senha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // senha
            // 
            this.senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.senha.BackColor = System.Drawing.SystemColors.Window;
            this.senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senha.Font = new System.Drawing.Font("Arial", 12F);
            this.senha.ForeColor = System.Drawing.SystemColors.InfoText;
            this.senha.Location = new System.Drawing.Point(248, 197);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(304, 19);
            this.senha.TabIndex = 81;
            this.senha.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(374, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 80;
            this.label5.Text = "Senha";
            // 
            // usuario
            // 
            this.usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usuario.BackColor = System.Drawing.SystemColors.Window;
            this.usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuario.Font = new System.Drawing.Font("Arial", 12F);
            this.usuario.ForeColor = System.Drawing.SystemColors.InfoText;
            this.usuario.Location = new System.Drawing.Point(248, 121);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(304, 19);
            this.usuario.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(365, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 78;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(353, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 40);
            this.label2.TabIndex = 83;
            this.label2.Text = "Login";
            // 
            // entrar
            // 
            this.entrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.entrar.BackColor = System.Drawing.SystemColors.Window;
            this.entrar.BackgroundImage = global::Trabalho.Properties.Resources.abertura_da_porta_aberta;
            this.entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entrar.FlatAppearance.BorderSize = 0;
            this.entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrar.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.entrar.Location = new System.Drawing.Point(360, 256);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(108, 39);
            this.entrar.TabIndex = 84;
            this.entrar.UseVisualStyleBackColor = false;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
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
            this.ver_senha.Location = new System.Drawing.Point(517, 197);
            this.ver_senha.Name = "ver_senha";
            this.ver_senha.Size = new System.Drawing.Size(35, 19);
            this.ver_senha.TabIndex = 82;
            this.ver_senha.UseVisualStyleBackColor = false;
            this.ver_senha.Click += new System.EventHandler(this.ver_senha_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ver_senha);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ver_senha;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button entrar;
    }
}