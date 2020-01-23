namespace Controle_Veiculos.Classes.Interface
{
    partial class Fcadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EDITLOGIN = new System.Windows.Forms.TextBox();
            this.EDITSENHA = new System.Windows.Forms.TextBox();
            this.EDITSENHACONFIRMAR = new System.Windows.Forms.TextBox();
            this.BOTAOCADASTRAR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SENHA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // EDITLOGIN
            // 
            this.EDITLOGIN.Location = new System.Drawing.Point(38, 75);
            this.EDITLOGIN.Name = "EDITLOGIN";
            this.EDITLOGIN.Size = new System.Drawing.Size(193, 20);
            this.EDITLOGIN.TabIndex = 3;
            // 
            // EDITSENHA
            // 
            this.EDITSENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDITSENHA.Location = new System.Drawing.Point(39, 124);
            this.EDITSENHA.MaxLength = 14;
            this.EDITSENHA.Name = "EDITSENHA";
            this.EDITSENHA.PasswordChar = '*';
            this.EDITSENHA.Size = new System.Drawing.Size(192, 22);
            this.EDITSENHA.TabIndex = 4;
            // 
            // EDITSENHACONFIRMAR
            // 
            this.EDITSENHACONFIRMAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDITSENHACONFIRMAR.Location = new System.Drawing.Point(39, 176);
            this.EDITSENHACONFIRMAR.MaxLength = 14;
            this.EDITSENHACONFIRMAR.Name = "EDITSENHACONFIRMAR";
            this.EDITSENHACONFIRMAR.PasswordChar = '*';
            this.EDITSENHACONFIRMAR.Size = new System.Drawing.Size(192, 22);
            this.EDITSENHACONFIRMAR.TabIndex = 5;
            // 
            // BOTAOCADASTRAR
            // 
            this.BOTAOCADASTRAR.Location = new System.Drawing.Point(75, 221);
            this.BOTAOCADASTRAR.Name = "BOTAOCADASTRAR";
            this.BOTAOCADASTRAR.Size = new System.Drawing.Size(120, 38);
            this.BOTAOCADASTRAR.TabIndex = 6;
            this.BOTAOCADASTRAR.Text = "CADASTRAR";
            this.BOTAOCADASTRAR.UseVisualStyleBackColor = true;
            this.BOTAOCADASTRAR.Click += new System.EventHandler(this.BOTAOCADASTRAR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CONFIRMAR SENHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "A senha deve possuir no maximo 14 caracteres";
            // 
            // Fcadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 300);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BOTAOCADASTRAR);
            this.Controls.Add(this.EDITSENHACONFIRMAR);
            this.Controls.Add(this.EDITSENHA);
            this.Controls.Add(this.EDITLOGIN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Fcadastro";
            this.Text = "Cadastrar LoginModelo";
            this.Load += new System.EventHandler(this.Fcadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EDITLOGIN;
        private System.Windows.Forms.TextBox EDITSENHA;
        private System.Windows.Forms.TextBox EDITSENHACONFIRMAR;
        private System.Windows.Forms.Button BOTAOCADASTRAR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}