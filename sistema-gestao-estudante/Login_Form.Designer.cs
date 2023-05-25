namespace sistema_gestao_estudante
{
    partial class Login_Form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.Usuário = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.btnentrar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(52, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(147, 277);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(129, 20);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(147, 319);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(129, 20);
            this.txtsenha.TabIndex = 2;
            // 
            // Usuário
            // 
            this.Usuário.AutoSize = true;
            this.Usuário.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuário.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Usuário.Location = new System.Drawing.Point(39, 271);
            this.Usuário.Name = "Usuário";
            this.Usuário.Size = new System.Drawing.Size(93, 25);
            this.Usuário.TabIndex = 3;
            this.Usuário.Text = "Usuário";
            this.Usuário.Click += new System.EventHandler(this.Usuário_Click);
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.Location = new System.Drawing.Point(47, 313);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(79, 25);
            this.Senha.TabIndex = 4;
            this.Senha.Text = "Senha";
            // 
            // btnentrar
            // 
            this.btnentrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnentrar.BackColor = System.Drawing.Color.Gray;
            this.btnentrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnentrar.Location = new System.Drawing.Point(32, 371);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(100, 50);
            this.btnentrar.TabIndex = 5;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Gray;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelar.Location = new System.Drawing.Point(176, 371);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 50);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(312, 450);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Usuário);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login_Form";
            this.Text = "Entrar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label Usuário;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Button btncancelar;
    }
}

