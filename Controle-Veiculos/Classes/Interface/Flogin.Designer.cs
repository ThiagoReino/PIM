namespace Controle_Veiculos.Classes.Interface
{
    partial class Flogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EDITLOGIN = new System.Windows.Forms.TextBox();
            this.EDITSENHA = new System.Windows.Forms.TextBox();
            this.BOTAOSAIR = new System.Windows.Forms.Button();
            this.BOTAOCADASTRESE = new System.Windows.Forms.Button();
            this.BOTAOENTRAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_Veiculos.Properties.Resources.Person1;
            this.pictureBox1.Location = new System.Drawing.Point(28, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SENHA: ";
            // 
            // EDITLOGIN
            // 
            this.EDITLOGIN.Location = new System.Drawing.Point(273, 74);
            this.EDITLOGIN.Name = "EDITLOGIN";
            this.EDITLOGIN.Size = new System.Drawing.Size(161, 20);
            this.EDITLOGIN.TabIndex = 3;
            this.EDITLOGIN.Text = "1";
            this.EDITLOGIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EDITLOGIN_KeyPress);
            // 
            // EDITSENHA
            // 
            this.EDITSENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDITSENHA.Location = new System.Drawing.Point(273, 132);
            this.EDITSENHA.MaxLength = 14;
            this.EDITSENHA.Name = "EDITSENHA";
            this.EDITSENHA.PasswordChar = '*';
            this.EDITSENHA.Size = new System.Drawing.Size(161, 22);
            this.EDITSENHA.TabIndex = 4;
            this.EDITSENHA.Text = "1";
            this.EDITSENHA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EDITSENHA_KeyPress);
            // 
            // BOTAOSAIR
            // 
            this.BOTAOSAIR.Location = new System.Drawing.Point(359, 186);
            this.BOTAOSAIR.Name = "BOTAOSAIR";
            this.BOTAOSAIR.Size = new System.Drawing.Size(75, 23);
            this.BOTAOSAIR.TabIndex = 6;
            this.BOTAOSAIR.Text = "SAIR";
            this.BOTAOSAIR.UseVisualStyleBackColor = false;
            this.BOTAOSAIR.Click += new System.EventHandler(this.BOTAOSAIR_Click);
            // 
            // BOTAOCADASTRESE
            // 
            this.BOTAOCADASTRESE.Location = new System.Drawing.Point(291, 226);
            this.BOTAOCADASTRESE.Name = "BOTAOCADASTRESE";
            this.BOTAOCADASTRESE.Size = new System.Drawing.Size(118, 42);
            this.BOTAOCADASTRESE.TabIndex = 7;
            this.BOTAOCADASTRESE.Text = "CADASTRE - SE";
            this.BOTAOCADASTRESE.UseVisualStyleBackColor = false;
            this.BOTAOCADASTRESE.Click += new System.EventHandler(this.BOTAOCADASTRESE_Click);
            // 
            // BOTAOENTRAR
            // 
            this.BOTAOENTRAR.Location = new System.Drawing.Point(273, 186);
            this.BOTAOENTRAR.Name = "BOTAOENTRAR";
            this.BOTAOENTRAR.Size = new System.Drawing.Size(75, 23);
            this.BOTAOENTRAR.TabIndex = 5;
            this.BOTAOENTRAR.Text = "ENTRAR";
            this.BOTAOENTRAR.UseVisualStyleBackColor = false;
            this.BOTAOENTRAR.Click += new System.EventHandler(this.BOTAOENTRAR_Click);
            // 
            // Flogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 304);
            this.Controls.Add(this.BOTAOCADASTRESE);
            this.Controls.Add(this.BOTAOSAIR);
            this.Controls.Add(this.BOTAOENTRAR);
            this.Controls.Add(this.EDITSENHA);
            this.Controls.Add(this.EDITLOGIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(482, 304);
            this.MinimumSize = new System.Drawing.Size(482, 304);
            this.Name = "Flogin";
            this.Text = "LoginModelo";
            this.Load += new System.EventHandler(this.Flogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EDITLOGIN;
        private System.Windows.Forms.TextBox EDITSENHA;
        private System.Windows.Forms.Button BOTAOSAIR;
        private System.Windows.Forms.Button BOTAOCADASTRESE;
        private System.Windows.Forms.Button BOTAOENTRAR;
    }
}