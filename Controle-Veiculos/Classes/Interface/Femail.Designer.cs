namespace Controle_Veiculos.Classes.Interface
{
    partial class Femail
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
            this.EDITDESTINATARIO = new System.Windows.Forms.TextBox();
            this.EDITASSUNTO = new System.Windows.Forms.TextBox();
            this.EDITMENSAGEM = new System.Windows.Forms.TextBox();
            this.BOTAOENVIAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BOTAONOVO = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EDITDESTINATARIO
            // 
            this.EDITDESTINATARIO.Location = new System.Drawing.Point(74, 22);
            this.EDITDESTINATARIO.Name = "EDITDESTINATARIO";
            this.EDITDESTINATARIO.Size = new System.Drawing.Size(401, 20);
            this.EDITDESTINATARIO.TabIndex = 0;
            // 
            // EDITASSUNTO
            // 
            this.EDITASSUNTO.Location = new System.Drawing.Point(74, 58);
            this.EDITASSUNTO.Name = "EDITASSUNTO";
            this.EDITASSUNTO.Size = new System.Drawing.Size(401, 20);
            this.EDITASSUNTO.TabIndex = 1;
            // 
            // EDITMENSAGEM
            // 
            this.EDITMENSAGEM.Location = new System.Drawing.Point(15, 127);
            this.EDITMENSAGEM.Multiline = true;
            this.EDITMENSAGEM.Name = "EDITMENSAGEM";
            this.EDITMENSAGEM.Size = new System.Drawing.Size(500, 180);
            this.EDITMENSAGEM.TabIndex = 2;
            // 
            // BOTAOENVIAR
            // 
            this.BOTAOENVIAR.Location = new System.Drawing.Point(440, 313);
            this.BOTAOENVIAR.Name = "BOTAOENVIAR";
            this.BOTAOENVIAR.Size = new System.Drawing.Size(75, 23);
            this.BOTAOENVIAR.TabIndex = 3;
            this.BOTAOENVIAR.Text = "Enviar";
            this.BOTAOENVIAR.UseVisualStyleBackColor = true;
            this.BOTAOENVIAR.Click += new System.EventHandler(this.BOTAOENVIAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Assunto:";
            // 
            // BOTAONOVO
            // 
            this.BOTAONOVO.Location = new System.Drawing.Point(15, 313);
            this.BOTAONOVO.Name = "BOTAONOVO";
            this.BOTAONOVO.Size = new System.Drawing.Size(75, 23);
            this.BOTAONOVO.TabIndex = 6;
            this.BOTAONOVO.Text = "Novo Email";
            this.BOTAONOVO.UseVisualStyleBackColor = true;
            this.BOTAONOVO.Click += new System.EventHandler(this.BOTAONOVO_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EDITASSUNTO);
            this.groupBox1.Controls.Add(this.EDITDESTINATARIO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "De : Para";
            // 
            // Femail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 349);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BOTAONOVO);
            this.Controls.Add(this.BOTAOENVIAR);
            this.Controls.Add(this.EDITMENSAGEM);
            this.MaximumSize = new System.Drawing.Size(542, 388);
            this.MinimumSize = new System.Drawing.Size(542, 388);
            this.Name = "Femail";
            this.Text = "Correio Eletrônico";
            this.Load += new System.EventHandler(this.Femail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EDITDESTINATARIO;
        private System.Windows.Forms.TextBox EDITASSUNTO;
        private System.Windows.Forms.TextBox EDITMENSAGEM;
        private System.Windows.Forms.Button BOTAOENVIAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BOTAONOVO;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}